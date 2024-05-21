using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources; // Often not needed, depending on project setup
using Library.Properties; // Replace 'Library' with your actual namespace, if different


namespace Library
{
    public partial class home : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
        public static class SessionInfo
        {
            public static int CurrentStudentId { get; set; }
        }

        public home()
        {
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
            LoadStudentInfo(); // Load and display the info of the logged-in student
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addbk_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook addBook = new AddBook(SessionInfo.CurrentStudentId);  // Pass currentStudentId
            addBook.ShowDialog();
        }
        public void LoadStudentInfo()
        {
            int studentId = SessionInfo.CurrentStudentId; // Ensure this is correctly set
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT FirstName, LastName, Photo FROM Students WHERE StudentID = @StudentId";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Data found, preparing to display..."); // Debug message
                                DisplayStudentInfo(reader); // Display the student info
                            }
                            else
                            {
                                MessageBox.Show("Student information not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void DisplayStudentInfo(MySqlDataReader reader)
        {
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            byte[] photoBytes = reader["Photo"] as byte[];

            // Debug: Check if data is correctly extracted
            MessageBox.Show($"Name: {firstName} {lastName}\nPhoto Bytes Length: {photoBytes?.Length ?? 0}");

            HomeStdNameLabel.Text = $"{firstName} {lastName}";

            if (photoBytes != null && photoBytes.Length > 0)
            {
                using (var ms = new MemoryStream(photoBytes))
                {
                    Image originalImage = Image.FromStream(ms);
                    HomeStdPic.Visible = true;
                    HomeStdNameLabel.Visible = true;
                    HomeStdPic.Image = GetEllipseImage(originalImage); // Set the elliptical image
                }
            }
            else
            {
                MessageBox.Show("Student image not found.");
            }
        }



        private Image GetEllipseImage(Image originalImage)
        {
            // Create a new bitmap with the same dimensions as the original image
            Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Transparent); // Set background color to transparent
                GraphicsPath path = new GraphicsPath();

                // Add an ellipse to the path that has the same dimensions as the image
                path.AddEllipse(0, 0, originalImage.Width, originalImage.Height);
                g.SetClip(path);

                // Draw the original image onto the bitmap which is clipped to the ellipse
                g.DrawImage(originalImage, 0, 0);
            }

            return bitmap; // Return the elliptically clipped image
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logout();  // Call the logout method only if the user confirms
            }
        }
        public void Logout()
        {
            // Reset the session ID
            SessionInfo.CurrentStudentId = 0;

            // Optionally, clear any other session-related data or perform other cleanup tasks

            // Close the current form and show the login form
            this.Hide();
            var loginForm = new Form1();  // Assuming Form1 is your login form
            loginForm.FormClosed += (s, args) => this.Close();  // Ensure the entire application closes when the login form is closed
            loginForm.Show();
        }

        private void showAdminpanael_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminpanel adminpanel = new adminpanel();
            adminpanel.ShowDialog();
        }
    }
}

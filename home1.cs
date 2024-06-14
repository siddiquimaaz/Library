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

        public home()
        {
            InitializeComponent();
        }
        private void home_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private async void LoadUserData()
        {
            try
            {
                int userId = Form1.SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo
                if (userId != -1)
                {
                    await LoadStudentInfo(userId);
                }
                else
                {
                    MessageBox.Show("User ID is invalid or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void addbk_Click(object sender, EventArgs e)
        {
            int studentId = Form1.SessionInfo.CurrentStudentId;
            AddBook addBookForm = new AddBook();
            addBookForm.Show();
        }

        public async Task LoadStudentInfo(int userId)
        {
            try
            {
                // Query to fetch user information based on user ID
                string sql = "SELECT FirstName, LastName, Photo FROM Students WHERE StudentID = @StudentId";

                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", userId);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                DisplayStudentInfo((MySqlDataReader)reader);
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayStudentInfo(MySqlDataReader reader)
        {
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            byte[] photoBytes = reader["Photo"] as byte[];

            HomeStdNameLabel.Text = $"{firstName} {lastName}";

            if (photoBytes != null && photoBytes.Length > 0)
            {
                using (var ms = new MemoryStream(photoBytes))
                {
                    Image originalImage = Image.FromStream(ms);
                    HomeStdPic.Visible = true;
                    HomeStdNameLabel.Visible = true;
                    HomeStdPic.Image = GetEllipseImage(originalImage);
                }
            }
            else
            {
                MessageBox.Show("Student image not found.");
            }
        }

        private Image GetEllipseImage(Image originalImage)
        {
            Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Transparent);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, originalImage.Width, originalImage.Height);
                g.SetClip(path);
                g.DrawImage(originalImage, 0, 0);
            }

            return bitmap;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Logout();
            }
        }

        public void Logout()
        {
            Form1.SessionInfo.CurrentStudentId = 0;
            Form1.SessionInfo.CurrentStudentEmail = null;
            this.Close();
            var loginForm = new Form1();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void showAdminpanael_Click(object sender, EventArgs e)
        {
            FormManager.Show(new adminpanel());
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            FormManager.Show(new ReaderCredentials());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ReaderReturnBookBtn_Click(object sender, EventArgs e)
        {
            FormManager.Show(new ReaderReturnBook());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }

        private void HomeStdPic_Click(object sender, EventArgs e){}
    }


}

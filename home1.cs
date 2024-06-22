using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class home : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        public home()
        {
            InitializeComponent();
            FormManager.AttachUserActivityHandlers(this);
        }

        private void home_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private async void LoadUserData()
        {
            try
            {
                int userId = SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo
                if (userId != -1)
                {
                    await StudentInfo.Instance.LoadStudentInfoAsync(userId, connectionString);
                    DisplayStudentInfo(); // Display the loaded student info
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

        private void DisplayStudentInfo()
        {
            var studentInfo = StudentInfo.Instance;

            HomeStdNameLabel.Text = $"{studentInfo.FirstName} {studentInfo.LastName}";

            if (studentInfo.Photo != null && studentInfo.Photo.Length > 0)
            {
                using (var ms = new MemoryStream(studentInfo.Photo))
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

        private void addbk_Click(object sender, EventArgs e)
        {
            int studentId = SessionInfo.CurrentStudentId;
            FormManager.CloseCurrentForm();
            FormManager.Show(new AddBook());
            FormManager.RecordUserActivity();
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
            FormManager.RecordUserActivity();
            FormManager.ClearSession();
            FormManager.CloseCurrentForm();
            FormManager.Show(new Form1());
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new ReaderCredentials());
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new ReaderDetails());
        }

        private void ReaderReturnBookBtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new ReaderReturnBook());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }

        private void HomeStdPic_Click(object sender, EventArgs e) { }
    }
}

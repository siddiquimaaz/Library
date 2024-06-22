using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using static Library.home;
using System.Resources; // Often not needed, depending on project setup
using Library.Properties; // Replace 'Library' with your actual namespace, if different

namespace Library
{
    public partial class Signup : Form
    {
         private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
       
        //private string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        private UserManager userManager;

        public Signup()
        {
            InitializeComponent();
            userManager = new UserManager(connectionString);
        }

        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstnametxt.Text;
            string lastName = lastnametxt.Text;
            string phoneNumber = phonenumbertxt.Text;
            string email = emailtxt.Text;
            string password = passwordtxt.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] imageBytes = null;
            if (addpic.Image != null)
            {
                imageBytes = ConvertImageToBytes(addpic.Image);
            }
            else
            {
                MessageBox.Show("Please upload an image before registering.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution since the image is mandatory
            }

            try
            {
                int studentId = await userManager.RegisterUserAsync(firstName, lastName, email, hashedPassword, phoneNumber, imageBytes);
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessionInfo.CurrentStudentId = studentId;

                // Set session details
                FormManager.SetSession(studentId);

                // Debug output to verify the ID
                MessageBox.Show($"Current Student ID: {SessionInfo.CurrentStudentId}");
                FormManager.CloseCurrentForm();
                FormManager.Show(new home());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to validate email
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private System.Drawing.Image GetEllipseImage(System.Drawing.Image originalImage)
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

        private void selectimg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image originalImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    System.Drawing.Image ellipseImage = GetEllipseImage(originalImage);
                    addpic.Image = ellipseImage;
                    addpic.Visible = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void ReaderBackBtn_Click(object sender, EventArgs e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new Form1());
        }

        private void SignUpCloseLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteArray = ms.ToArray();
                MessageBox.Show($"Image byte array size: {byteArray.Length}"); // Debug message
                return byteArray;
            }
        }
    }
}

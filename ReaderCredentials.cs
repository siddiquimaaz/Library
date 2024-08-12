using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
namespace Library
{
    public partial class ReaderCredentials : Form
    {
        //private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=Zain1234;";


        public ReaderCredentials()
        {
            InitializeComponent();
            this.Load += new EventHandler(ReaderCredentials_Load);
            printIdCard.Click += new EventHandler(printIdCard_Click);
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            FormManager.AttachUserActivityHandlers(this);

        }

        private void label2_Click(object sender, EventArgs e) { }

        private void readerid_Click(object sender, EventArgs e) { }

        private async void ReaderCredentials_Load(object sender, EventArgs e)
        {
            await LoadUserData();
            FormManager.AttachUserActivityHandlers(this);
        }

        private async Task LoadUserData()
        {
            try
            {
                int userId = SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo
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

        public async Task LoadStudentInfo(int userId)
        {
            try
            {
                // Query to fetch user information based on user ID
                string sql = "SELECT FirstName, LastName, Photo, Email, StudentID, PhoneNumber FROM Students WHERE StudentID = @StudentId";

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
            string email = reader["Email"].ToString();
            string readerId = reader["StudentID"].ToString();
            string readerPhoneNo = reader["PhoneNumber"].ToString();
            byte[] photoBytes = reader["Photo"] as byte[];

            readerName.Text = $"{firstName} {lastName}";
            this.readerId.Text = readerId;
            this.readerPhoneNo.Text = readerPhoneNo;
            readerEmail.Text = email;

            if (photoBytes != null && photoBytes.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(photoBytes))
                    {
                        System.Drawing.Image originalImage = System.Drawing.Image.FromStream(ms);
                        readerPicture.Visible = true;
                        readerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        readerPicture.Image = GetEllipseImage(originalImage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                readerPicture.Image = null; // Clear the picture box
                MessageBox.Show("Student image not found.");
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

        private async void printIdCard_Click(object? sender, EventArgs? e)
        {
            FormManager.RecordUserActivity();
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        printDocument1.Print();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                // Define fonts and colors
                Font titleFont = new Font("Arial", 18, FontStyle.Bold);
                Font labelFont = new Font("Arial", 12, FontStyle.Regular);
                Font infoFont = new Font("Arial", 12, FontStyle.Italic);
                Brush titleBrush = new SolidBrush(Color.Black);
                Brush labelBrush = new SolidBrush(Color.DarkBlue);
                Brush infoBrush = new SolidBrush(Color.DarkGreen);

                // Draw elements
                g.DrawString("Library ID Card", titleFont, titleBrush, 100, 50);

                g.DrawString("Reader ID:", labelFont, labelBrush, 50, 120);
                g.DrawString(readerId.Text, infoFont, infoBrush, 200, 120);

                g.DrawString("Name:", labelFont, labelBrush, 50, 160);
                g.DrawString(readerName.Text, infoFont, infoBrush, 200, 160);

                g.DrawString("Phone No:", labelFont, labelBrush, 50, 200);
                g.DrawString(readerPhoneNo.Text, infoFont, infoBrush, 200, 200);

                g.DrawString("Email:", labelFont, labelBrush, 50, 240);
                g.DrawString(readerEmail.Text, infoFont, infoBrush, 200, 240);

                // Draw signature lines
                g.DrawString(signdash.Text, labelFont, labelBrush, 50, 280);
                g.DrawString(signlabel.Text, infoFont, infoBrush, 200, 280);

                // Draw reader picture
                if (readerPicture.Image != null)
                {
                    g.DrawImage(readerPicture.Image, 400, 120, 100, 100);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while drawing the ID card: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
    }
}

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
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Library
{
    public partial class ReaderCredentials : Form
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
        


        public ReaderCredentials()
        {
            InitializeComponent();
    
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void readerid_Click(object sender, EventArgs e) { }

        private async void ReaderCredentials_Load(object sender, EventArgs e)
        {
            await LoadUserData();
        }

        private async Task LoadUserData()
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

            readername.Text = $"{firstName} {lastName}";
            readerid.Text = readerId;
            readerphoneno.Text = readerPhoneNo;
            readeremail.Text = email;

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
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Reader ID Card as PDF";
                saveFileDialog.FileName = $"ReaderIDCard_{readerid.Text}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    try
                    {
                        //await CreatePdfWithStudentInfo(fileName);
                        MessageBox.Show("PDF created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while creating the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
       
        /* private async Task CreatePdfWithStudentInfo(string fileName)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (PdfDocument document = new PdfDocument())
                    {
                        PdfPage page = document.AddPage();
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XFont fontRegular = new XFont("Arial", 12);
                        XFont fontBold = new XFont("Arial", 20);

                        // Draw the title
                        gfx.DrawString("Library Card", fontBold, XBrushes.Black,
                            new XRect(0, 0, page.Width, 50), XStringFormats.TopCenter);

                        // Draw the image
                        if (readerPicture.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                readerPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                XImage xImage = XImage.FromStream(ms);
                                gfx.DrawImage(xImage, (page.Width - 100) / 2, 60, 100, 100);
                            }
                        }

                        // Draw the student information
                        gfx.DrawString("Name: " + readername.Text, fontRegular, XBrushes.Black,
                            new XRect(40, 200, page.Width - 80, 20), XStringFormats.TopLeft);
                        gfx.DrawString("ID: " + readerid.Text, fontRegular, XBrushes.Black,
                            new XRect(40, 230, page.Width - 80, 20), XStringFormats.TopLeft);
                        gfx.DrawString("Email: " + readeremail.Text, fontRegular, XBrushes.Black,
                            new XRect(40, 260, page.Width - 80, 20), XStringFormats.TopLeft);
                        gfx.DrawString("Phone Number: " + readerphoneno.Text, fontRegular, XBrushes.Black,
                            new XRect(40, 290, page.Width - 80, 20), XStringFormats.TopLeft);

                        // Save the document
                        document.Save(fileName);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/



    }
}

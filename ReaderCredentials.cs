using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;

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

        private void ReaderCredentials_Load(object sender, EventArgs e)
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

                        // Debug message to confirm the image is set
                        MessageBox.Show("Image loaded and set to PictureBox successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Debug message for image loading failure
                    MessageBox.Show($"An error occurred while loading the image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Student image not found.");
                readerPicture.Image = null; // Clear the picture box

                // Debug message when image is not found
                MessageBox.Show("Student image not found in the database.");
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

        private async void printIdCard_Click(object sender, EventArgs e)
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
                        Task.Run(async () => await CreatePdfWithStudentInfo(fileName)).Wait();
                        MessageBox.Show("PDF created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while creating the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine($"An error occurred while creating the PDF: {ex.Message}");
                    }
                }
            }
        }

        private async Task CreatePdfWithStudentInfo(string fileName)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(fileName))
                {
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Add the student information to the PDF
                    document.Add(new Paragraph($"Name: {readername.Text}"));
                    document.Add(new Paragraph($"ID: {readerid.Text}"));
                    document.Add(new Paragraph($"Email: {readeremail.Text}"));
                    document.Add(new Paragraph($"Phone Number: {readerphoneno.Text}"));

                    // Add the student photo to the PDF
                    if (readerPicture.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            readerPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            ImageData imageData = ImageDataFactory.Create(ms.ToArray());
                            iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                            document.Add(pdfImage);
                        }
                    }

                    document.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while creating the PDF: {ex.Message}", ex);
            }
        }



    }
}

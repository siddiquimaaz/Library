using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReaderDetails : Form
    {
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
        private int currentStudentId;

        public ReaderDetails()
        {
            InitializeComponent();
            currentStudentId = Form1.SessionInfo.CurrentStudentId; // Capture the current student ID
            LoadUserDetailsAsync(); // Call the async method to load user details
        }

        private async Task LoadUserDetailsAsync()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT FirstName, LastName, Email, PhoneNumber, MembershipExpiration, Photo FROM Students WHERE StudentID = @StudentID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", currentStudentId);

                        using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                FirstNameTxt.Text = reader.GetString(reader.GetOrdinal("FirstName"));
                                LastNameTxt.Text = reader.GetString(reader.GetOrdinal("LastName"));
                                EmailTxt.Text = reader.GetString(reader.GetOrdinal("Email"));
                                PhoneNumberTxt.Text = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                                MemberShipDateTimePicker.Value = reader.GetDateTime(reader.GetOrdinal("MembershipExpiration"));

                                if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                                {
                                    byte[] photoBytes = (byte[])reader["Photo"];
                                    using (MemoryStream ms = new MemoryStream(photoBytes))
                                    {
                                        ReaderPic.Image = Image.FromStream(ms);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user details: " + ex.Message);
            }
        }

        private void ReaderBackBtn_Click(object? sender, EventArgs? e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new home());
        }

        private void ReadersDetailsCancelBtn_Click(object? sender, EventArgs? e)
        {
            FirstNameTxt.Text = string.Empty;
            LastNameTxt.Text = string.Empty;
            PhoneNumberTxt.Text = string.Empty;
            PasswordTxt.Text = string.Empty;
            ReWritePasswordTxt.Text = string.Empty;
        }

        private void BrowseBtn_Click(object? sender, EventArgs? e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image originalImage = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    System.Drawing.Image ellipseImage = GetEllipseImage(originalImage);
                    ReaderPic.Image = ellipseImage;
                    ReaderPic.Visible = true;
                }
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

        private byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private async void ReadersDetailsUpdateBtn_Click(object? sender, EventArgs? e)
        {
            // Prompt user to enter the current password
            string enteredPassword = PromptForPassword();

            if (string.IsNullOrEmpty(enteredPassword))
            {
                MessageBox.Show("Password is required.");
                return;
            }

            if (await VerifyPasswordAsync(enteredPassword))
            {
                await UpdateReaderDetailsAsync();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.");
            }
        }

        private string PromptForPassword()
        {
            string password = null;

            using (var passwordForm = new Form())
            {
                passwordForm.Text = "Enter Current Password";
                passwordForm.Width = 400;
                passwordForm.Height = 150;

                Label label = new Label() { Left = 50, Top = 20, Text = "Current Password", Width = 300 };
                TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 280, PasswordChar = '*' };
                Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 100 };

                confirmation.Click += (sender, e) =>
                {
                    password = textBox.Text;
                    passwordForm.DialogResult = DialogResult.OK;
                    passwordForm.Close();
                };

                passwordForm.Controls.Add(textBox);
                passwordForm.Controls.Add(confirmation);
                passwordForm.Controls.Add(label);
                passwordForm.StartPosition = FormStartPosition.CenterScreen;
                passwordForm.AcceptButton = confirmation;

                passwordForm.ShowDialog();
            }

            return password;
        }

        private async Task<bool> VerifyPasswordAsync(string enteredPassword)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT HashedPassword FROM Students WHERE StudentID = @StudentID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", currentStudentId);
                        string storedHashedPassword = (string)await cmd.ExecuteScalarAsync();

                        return storedHashedPassword != null && BCrypt.Net.BCrypt.Verify(enteredPassword, storedHashedPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying password: " + ex.Message);
                return false;
            }
        }

        private async Task UpdateReaderDetailsAsync()
        {
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string phoneNumber = PhoneNumberTxt.Text;
            DateTime membershipExpiration = MemberShipDateTimePicker.Value;
            byte[] photo = ReaderPic.Image != null ? ConvertImageToBytes(ReaderPic.Image) : null;
            string newPassword = PasswordTxt.Text;
            string newPasswordRewrite = ReWritePasswordTxt.Text;

            if (!string.IsNullOrEmpty(newPassword) && newPassword != newPasswordRewrite)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    using (MySqlTransaction transaction = await conn.BeginTransactionAsync())
                    {
                        try
                        {
                            string updateQuery = @"
                                UPDATE Students 
                                SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, 
                                    MembershipExpiration = @MembershipExpiration, Photo = @Photo {0}
                                WHERE StudentID = @StudentID";

                            if (!string.IsNullOrEmpty(newPassword))
                            {
                                string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                                updateQuery = string.Format(updateQuery, ", HashedPassword = @HashedPassword");

                                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                                    cmd.Parameters.AddWithValue("@LastName", lastName);
                                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                    cmd.Parameters.AddWithValue("@MembershipExpiration", membershipExpiration);
                                    cmd.Parameters.AddWithValue("@Photo", photo);
                                    cmd.Parameters.AddWithValue("@HashedPassword", hashedNewPassword);
                                    cmd.Parameters.AddWithValue("@StudentID", currentStudentId);

                                    await cmd.ExecuteNonQueryAsync();
                                }
                            }
                            else
                            {
                                updateQuery = string.Format(updateQuery, "");

                                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                                    cmd.Parameters.AddWithValue("@LastName", lastName);
                                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                                    cmd.Parameters.AddWithValue("@MembershipExpiration", membershipExpiration);
                                    cmd.Parameters.AddWithValue("@Photo", photo);
                                    cmd.Parameters.AddWithValue("@StudentID", currentStudentId);

                                    await cmd.ExecuteNonQueryAsync();
                                }
                            }

                            await transaction.CommitAsync();
                            MessageBox.Show("Details updated successfully.");
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            MessageBox.Show("Update failed: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating details: " + ex.Message);
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void ReaderDetailsLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

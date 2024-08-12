using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using System.Threading.Tasks;
using System.Data;

namespace Library
{
    public partial class Form1 : Form
    {
        //string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=Zain1234;";
        public Form1()
        {
            InitializeComponent();
            FormManager.Show(this);
            FormManager.AttachUserActivityHandlers(this);
        }
        private async Task<int> ValidateCredentialsAsync(string email, string password, bool isAdmin)
        {
            string table = isAdmin ? "AdminUsers" : "Students";
            string idColumn = isAdmin ? "UserID" : "StudentID";
            int userId = -1;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string query = $"SELECT {idColumn}, HashedPassword FROM {table} WHERE Email = @Email";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string hashedPassword = reader.GetString("HashedPassword");

                                if (isAdmin)
                                {
                                    if (password == hashedPassword)
                                    {
                                        userId = reader.GetInt32(idColumn);
                                        SessionInfo.CurrentAdminId = userId;
                                        SessionInfo.CurrentAdminEmail = email;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid password for admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                    {
                                        userId = reader.GetInt32(idColumn);
                                        SessionInfo.CurrentStudentId = userId;
                                        SessionInfo.CurrentStudentEmail = email;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid password for student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No matching record found for the email: {email}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Error validating credentials.", ex);
            }

            return userId;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new Signup());
            FormManager.RecordUserActivity();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginUserAsync();
            FormManager.RecordUserActivity();
        }

        private async void LoginUserAsync()
        {
            try
            {
                string email = text1.Text.Trim();
                string password = text2.Text;
                bool isAdmin = checkadmin.Checked;

                int userId = await ValidateCredentialsAsync(email, password, isAdmin);
                if (userId != -1)
                {
                    if (isAdmin)
                    {
                        FormManager.CloseCurrentForm();
                        FormManager.Show(new adminpanel());
                    }
                    else
                    {
                        FormManager.CloseCurrentForm();
                        FormManager.Show(new home());
                        FormManager.SetSession(userId); // Set session expiration for the student
                    }
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            text2.UseSystemPasswordChar = !checkBox1.Checked;
            FormManager.RecordUserActivity();
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void LoginCloseBtn_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

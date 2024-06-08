using MySql.Data.MySqlClient;
using BCrypt.Net;
using static Library.home;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace Library
{
    public partial class Form1 : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public Form1()
        {
            InitializeComponent();
            FormManager.Show(this); // Use FormManager to show the form
        }
        public static class SessionInfo
        {
            public static int CurrentStudentId { get; set; }
            public static string CurrentStudentEmail { get; set; }
            public static int CurrentAdminId { get; set; }
            public static string CurrentAdminEmail { get; set; }
        }

        private async Task<int> ValidateCredentialsAsync(string email, string password, bool isAdmin)
        {
            string table = isAdmin ? "AdminUsers" : "Students";
            string idColumn = isAdmin ? "UserID" : "StudentID"; // Remove the space before "UserID"
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

                                // For admin users, check password directly (since it's not hashed)
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
                                else  // For student users, verify hashed password
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Head_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginUserAsync(); // Call async method
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
                        FormManager.Show(new adminpanel());
                    }
                    else
                    {
                        home homeForm = new home();
                        await homeForm.LoadStudentInfo(userId); // Load student info
                        FormManager.Show(homeForm);
                    }
                    // Do not close the current form here
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception or take appropriate action
            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            text2.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {}private void label2_Click(object sender, EventArgs e){}
    }

}


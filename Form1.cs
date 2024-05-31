using MySql.Data.MySqlClient;
using BCrypt.Net;
using static Library.home;
namespace Library
{
    public partial class Form1 : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public Form1()
        {
            InitializeComponent();
        }
        public static class SessionInfo
        {
            public static int CurrentStudentId { get; set; }
            public static string CurrentStudentEmail { get; set; }
        }

        private async Task<int> ValidateCredentialsAsync(string email, string password, bool isAdmin)
        {
            string table = isAdmin ? "AdminUsers" : "Students";
            string idColumn = isAdmin ? "AdminID" : "StudentID";
            int userId = -1;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    MessageBox.Show("Connected to the database successfully.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string query = $"SELECT {idColumn}, HashedPassword FROM {table} WHERE Email = @Email";
                    MessageBox.Show("Query: " + query, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        MessageBox.Show("Email parameter added: " + email, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string hashedPassword = reader["HashedPassword"].ToString();
                                MessageBox.Show("Retrieved hashed password from the database: " + hashedPassword, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    userId = Convert.ToInt32(reader[idColumn]);
                                    MessageBox.Show("User authenticated successfully. UserID: " + userId, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    SessionInfo.CurrentStudentId = userId;
                                    SessionInfo.CurrentStudentEmail = email;
                                }
                                else
                                {
                                    MessageBox.Show("Password verification failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching record found for the email: " + email, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Error validating credentials.", ex); // Rethrow with custom message
            }

            return userId;
        }



        private void sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) { }

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
                        adminpanel adminForm = new adminpanel();
                        this.Hide();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        home homeForm = new home();
                        this.Hide();
                        await homeForm.LoadStudentInfo(userId); // Load student info
                        homeForm.ShowDialog();
                    }
                    this.Close();
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
        }
    }

}


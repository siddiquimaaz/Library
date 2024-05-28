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
                    MessageBox.Show("Connected to the database successfully.");

                    string query = $"SELECT {idColumn}, HashedPassword FROM {table} WHERE Email = @Email";
                    MessageBox.Show("Query: " + query);

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        MessageBox.Show("Email parameter added: " + email);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                string hashedPassword = reader["HashedPassword"].ToString();
                                MessageBox.Show("Retrieved hashed password from the database: " + hashedPassword);

                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    userId = Convert.ToInt32(reader[idColumn]);
                                    MessageBox.Show("User authenticated successfully. UserID: " + userId);
                                    SessionInfo.CurrentStudentId = userId;
                                    MessageBox.Show("login finished ");
                                }
                                else
                                {
                                    MessageBox.Show("Password verification failed.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No matching record found for the email: " + email);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error message to the console for debugging purposes
                MessageBox.Show("1Error connecting to the database: " + ex.Message);
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

                int userId = await ValidateCredentialsAsync(email, password, isAdmin); // Await the async method
                if (userId != -1)
                {
                    MessageBox.Show($"User ID: {userId}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SessionInfo.CurrentStudentId = userId;

                    if (isAdmin)
                    {
                        // If the user is an admin, show the admin panel
                        adminpanel adminForm = new adminpanel();
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // If the user is not an admin, show the home form
                        home homeForm = new home();
                        this.Hide();
                        await homeForm.LoadStudentInfo(userId); // Load student info
                        homeForm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    // Display "Invalid credentials" message only when authentication fails
                    MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}


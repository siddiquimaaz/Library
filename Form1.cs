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
        private void Login_Click(object sender, EventArgs e)
        {
            string email = text1.Text.Trim();
            string password = text2.Text;
            bool isAdmin = checkadmin.Checked; // Check if the user is logging in as an admin

            int userId = ValidateCredentials(email, password, isAdmin);
            if (userId != -1)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SessionInfo.CurrentStudentId = userId;  // Set the session ID

                this.Hide();
                Form nextForm = isAdmin ? (Form)new adminpanel() : new home();  // Load admin panel or home based on user type
                nextForm.ShowDialog();
                this.Close();  // Close the login form after the next form is closed
            }
            else
            {
                MessageBox.Show("Invalid credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            text2.UseSystemPasswordChar = !checkBox1.Checked;
        }
        private int ValidateCredentials(string email, string password, bool isAdmin)
        {
            // Assuming 'AdminID' for admin table and 'StudentID' for student table
            string table = isAdmin ? "AdminUsers" : "Students";
            string idColumn = isAdmin ? "AdminID" : "StudentID";
            int userId = -1;  // Default to -1, indicating no user found

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT {idColumn}, HashedPassword FROM {table} WHERE Email = @Email";
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["HashedPassword"].ToString();
                                if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                                {
                                    userId = Convert.ToInt32(reader[idColumn]);  // Get the user ID from the database
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return userId;
        }
        private void sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}


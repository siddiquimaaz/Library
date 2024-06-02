using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BookManagegerAdmin : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        public BookManagegerAdmin()
        {
            InitializeComponent();
            submitBtn.Click += new EventHandler(submitBtn_Click); // Correct event handler assignment
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            // Collecting input data from the form fields
            string bookName = BooKNameAdmin.Text.Trim();
            string bookAuthor = BookAuthor.Text.Trim();
            string isbnNo = ISBNNo.Text.Trim();
            int publicationYear = dateTimePicker.Value.Year;
            string genre = Genre.Text.Trim();

            // Validating the input data
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(bookAuthor) || string.IsNullOrEmpty(isbnNo))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL Insert query
            string query = "INSERT INTO Books (Title, Author, ISBN, PublicationYear, Genre) VALUES (@Title, @Author, @ISBN, @PublicationYear, @Genre)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@Title", bookName);
                        command.Parameters.AddWithValue("@Author", bookAuthor);
                        command.Parameters.AddWithValue("@ISBN", isbnNo);
                        command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                        command.Parameters.AddWithValue("@Genre", genre);

                        // Executing the query asynchronously
                        int result = await command.ExecuteNonQueryAsync();

                        // Checking if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handling MySQL-specific exceptions
                MessageBox.Show($"A MySQL error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                // Handling invalid operations
                MessageBox.Show($"An invalid operation occurred: {ex.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handling any other general exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            FormManager.Show(new adminpanel());
        }
    }
}

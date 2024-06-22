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
    public partial class BookManagerAdmin : Form
    {
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        public BookManagerAdmin()
        {
            InitializeComponent();
            submitBtn.Click += new EventHandler(submitBtn_Click); // Correct event handler assignment
            FormManager.RecordUserActivity();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            FormManager.AttachUserActivityHandlers(this);
            // Collecting input data from the form fields
            string bookName = BooKNameAdmin.Text.Trim();
            string bookAuthor = BookAuthor.Text.Trim();
            string isbnNo = ISBNNo.Text.Trim();
            int publicationYear = dateTimePicker.Value.Year;
            string genre = Genre.Text.Trim();
            bool availablity = true;

            // Validating the input data
            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(bookAuthor) || string.IsNullOrEmpty(isbnNo))
            {
                MessageBox.Show("Please fill in all required fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL Insert query
            string query = "INSERT INTO Books (Title, Author, ISBN, PublicationYear, Genre, IsAvailable) VALUES (@Title, @Author, @ISBN, @PublicationYear, @Genre, @IsAvailable)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (MySqlTransaction transaction = await connection.BeginTransactionAsync())
                    {
                        try
                        {
                            using (MySqlCommand command = new MySqlCommand(query, connection, transaction))
                            {
                                // Adding parameters to prevent SQL injection
                                command.Parameters.AddWithValue("@Title", bookName);
                                command.Parameters.AddWithValue("@Author", bookAuthor);
                                command.Parameters.AddWithValue("@ISBN", isbnNo);
                                command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                                command.Parameters.AddWithValue("@Genre", genre);
                                command.Parameters.AddWithValue("@IsAvailable", availablity);

                                // Executing the query asynchronously
                                int result = await command.ExecuteNonQueryAsync();

                                // Checking if the insert was successful
                                if (result > 0)
                                {
                                    await transaction.CommitAsync();
                                    MessageBox.Show("Book added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    await transaction.RollbackAsync();
                                    MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            throw; // Re-throw the exception to be handled in the outer catch blocks
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

        private void submitBtn_Click_1(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminAddBookBackBtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new adminpanel());
        }
    }
}

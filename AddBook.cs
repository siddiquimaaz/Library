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
using BCrypt.Net;

namespace Library
{
    public partial class AddBook : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        private int currentStudentId;  // Field to store the current student's ID

        public AddBook(int studentId)
        {
            InitializeComponent();
            currentStudentId = studentId;
        }


        private void AddBook_Load(object sender, EventArgs e)
        {
            LoadBooksAsync();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            booktitltxt.Text = "";
            authortxt.Text = "";

            // Reload all books to reset the DataGridView's display
            LoadBooksAsync();  // Assuming LoadBooks() resets the DataGridView to show all books

            // Reset any other UI elements that might have changed
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooksAsync();
        }
        private async Task SearchBooksAsync()
        {
            string title = booktitltxt.Text.Trim();
            string author = authortxt.Text.Trim();

            // Build the SQL query dynamically based on user input
            var filters = new List<string>();
            if (!string.IsNullOrEmpty(title))
                filters.Add("Title LIKE @Title");
            if (!string.IsNullOrEmpty(author))
                filters.Add("Author LIKE @Author");

            // Only proceed if there is at least one filter
            if (filters.Count == 0)
            {
                MessageBox.Show("Please enter a title or author to search.");
                return;
            }

            string sql = $"SELECT BookID, Title, Author, ISBN, PublicationYear, Genre, IsAvailable FROM Books WHERE {string.Join(" AND ", filters)}";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        if (!string.IsNullOrEmpty(title))
                            cmd.Parameters.AddWithValue("@Title", $"%{title}%");
                        if (!string.IsNullOrEmpty(author))
                            cmd.Parameters.AddWithValue("@Author", $"%{author}%");

                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(dt));
                            booksView.DataSource = dt;

                            if (dt.Rows.Count == 0)
                            {
                                MessageBox.Show("No books found matching your criteria.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for books: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task LoadBooksAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT BookID, Title, Author, ISBN, PublicationYear, Genre, IsAvailable FROM Books";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Asynchronously fill the DataTable
                            await Task.Run(() => adapter.Fill(dt));  // Consider using FillAsync if available
                            booksView.Invoke(new Action(() => {
                                booksView.DataSource = dt;
                            }));
                        }
                    }
                }
                this.Invoke(new Action(() => SetupDataGridView()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider retry logic or alternative recovery measures here
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                booksView.AutoGenerateColumns = false;
                booksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                AddColumnIfMissing("Title", "Title");
                AddColumnIfMissing("Author", "Author");
                AddColumnIfMissing("ISBN", "ISBN");
                AddColumnIfMissing("PublicationYear", "Year", "Year");
                AddColumnIfMissing("Genre", "Genre");
                AddCheckboxColumnIfMissing("IsAvailable", "Available?", "IsAvailable");

                UpdateCheckBoxes();  // This method should also ensure correct read-only state
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up data grid view: {ex.Message}", "UI Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddColumnIfMissing(string columnName, string headerText, string dataPropertyName = null)
        {
            if (!booksView.Columns.Contains(columnName))
            {
                DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn
                {
                    Name = columnName,
                    HeaderText = headerText,
                    DataPropertyName = dataPropertyName ?? columnName
                };
                booksView.Columns.Add(textColumn);
            }
        }
        private void AddCheckboxColumnIfMissing(string columnName, string headerText, string dataPropertyName)
        {
            if (!booksView.Columns.Contains(columnName))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = columnName,
                    HeaderText = headerText,
                    DataPropertyName = dataPropertyName,
                    Width = 80,
                    ReadOnly = true,  // Set true here; will adjust dynamically in UpdateCheckBoxes
                    FalseValue = "False",
                    TrueValue = "True"
                };
                booksView.Columns.Add(checkBoxColumn);
            }
        }

        private void UpdateCheckBoxes()
        {
            try
            {
                foreach (DataGridViewRow row in booksView.Rows)
                {
                    if (row.IsNewRow) continue;

                    DataGridViewCheckBoxCell chkCell = row.Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                    if (chkCell != null)
                    {
                        bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                        chkCell.Value = !isAvailable;  // Check if not available
                        chkCell.ReadOnly = !isAvailable; // Read-only if not available
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update checkboxes: {ex.Message}", "Checkbox Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void addToStdbtn_Click(object sender, EventArgs e)
        {
            bool anyBookSelected = false;
            bool allSuccessfullyBorrowed = true;

            foreach (DataGridViewRow row in booksView.Rows)
            {
                var cell = row.Cells["IsAvailable"];
                if (cell.Value != DBNull.Value && Convert.ToBoolean(cell.Value))
                {
                    anyBookSelected = true;
                    int bookId = Convert.ToInt32(row.Cells["BookID"].Value);

                    try
                    {
                        bool wasBorrowedSuccessfully = await BorrowBookAsync(bookId);
                        if (!wasBorrowedSuccessfully)
                        {
                            allSuccessfullyBorrowed = false;
                            // Ensure the UI reflects the actual availability (i.e., not available)
                            row.Cells["IsAvailable"].Value = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception as needed
                        MessageBox.Show($"Failed to borrow book with ID {bookId}: {ex.Message}", "Borrowing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        allSuccessfullyBorrowed = false;
                        // If an error occurs, do not change the availability state
                    }
                }
            }

            if (!anyBookSelected)
            {
                MessageBox.Show("Please select an available book to borrow.");
            }
            else if (!allSuccessfullyBorrowed)
            {
                MessageBox.Show("Some of the selected books could not be borrowed as they may already be borrowed or are no longer available.");
            }
            else
            {
                MessageBox.Show("All selected books have been successfully borrowed.");
            }

            booksView.Refresh(); // Always refresh to reflect current state
        }


        private async void booksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && !booksView.Rows[e.RowIndex].IsNewRow && e.ColumnIndex == booksView.Columns["IsAvailable"].Index)
            {
                DataGridViewCheckBoxCell cell = booksView.Rows[e.RowIndex].Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                if (cell != null && !cell.ReadOnly)
                {
                    bool isChecked = Convert.ToBoolean(cell.Value);
                    cell.Value = !isChecked; // Toggle the checkbox state

                    if (!isChecked) // If it was unchecked before, now it is checked
                    {
                        int bookId = Convert.ToInt32(booksView.Rows[e.RowIndex].Cells["BookID"].Value);
                        bool wasBorrowedSuccessfully = await BorrowBookAsync(bookId);
                        if (wasBorrowedSuccessfully)
                        {
                            MessageBox.Show("Book borrowed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Book could not be borrowed. It may already be borrowed.");
                            cell.Value = isChecked; // Revert checkbox if operation failed
                        }
                        LoadBooksAsync();  // Always reload books to refresh the grid, ensuring consistency with the database
                    }
                }
            }
        }

        private async Task<bool> BorrowBookAsync(int bookId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        // Check if the book is currently available
                        string checkAvailableSql = "SELECT 1 FROM Books WHERE BookID = @BookId AND IsAvailable = true FOR UPDATE";
                        using (var checkCmd = new MySqlCommand(checkAvailableSql, connection, transaction))
                        {
                            checkCmd.Parameters.AddWithValue("@BookId", bookId);
                            var isAvailable = await checkCmd.ExecuteScalarAsync();

                            if (isAvailable == null)
                            {
                                throw new InvalidOperationException("This book is currently unavailable for borrowing.");
                            }

                            // Update the book's availability
                            string updateSql = "UPDATE Books SET IsAvailable = false WHERE BookID = @BookId";
                            using (var updateCmd = new MySqlCommand(updateSql, connection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@BookId", bookId);
                                await updateCmd.ExecuteNonQueryAsync();
                            }

                            // Log the borrowing
                            string insertSql = "INSERT INTO BorrowedBooks (StudentID, BookID, DateBorrowed, DueDate) VALUES (@StudentId, @BookId, NOW(), DATE_ADD(NOW(), INTERVAL 14 DAY))";
                            using (var insertCmd = new MySqlCommand(insertSql, connection, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@StudentId", currentStudentId);
                                insertCmd.Parameters.AddWithValue("@BookId", bookId);
                                await insertCmd.ExecuteNonQueryAsync();
                            }

                            await transaction.CommitAsync();
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"An error occurred while borrowing the book: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

    }
}

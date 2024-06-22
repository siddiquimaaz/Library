using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class ReaderReturnBook : Form
    {
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        private int currentStudentId;

        public ReaderReturnBook()
        {
            InitializeComponent();
            currentStudentId = SessionInfo.CurrentStudentId; // Assuming this is correctly set in your application
            InitializeDataGridView();
            Task task = LoadBorrowedBooksAsync(currentStudentId);
        }

        private void ReturnBookbackbtn_Click(object sender, EventArgs e)
        {
            FormManager.Show(new home());
        }

        private void InitializeDataGridView()
        {
            // Clear existing columns to avoid duplication
            ReturnBookDataGrid.Columns.Clear();

            // Set DataGridView properties
            ReturnBookDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReturnBookDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReturnBookDataGrid.MultiSelect = false;
            ReturnBookDataGrid.AllowUserToAddRows = false;
            ReturnBookDataGrid.AllowUserToResizeColumns = false;
            ReturnBookDataGrid.AllowUserToResizeRows = false;
            ReturnBookDataGrid.RowHeadersVisible = false;

            // Create checkbox column for book selection
            DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn();
            chkColumn.HeaderText = "Select";
            chkColumn.Name = "chkSelect";
            chkColumn.Width = 60;
            chkColumn.ReadOnly = false;
            ReturnBookDataGrid.Columns.Add(chkColumn);

            // Remove the empty row checkbox
            ReturnBookDataGrid.AllowUserToAddRows = false;
        }

      
        

        private async void BookIDSearchBtn_Click(object sender, EventArgs e)
        {
            int bookId;
            if (int.TryParse(BookIdTxt.Text, out bookId))
            {
                if (bookId <= 0)
                {
                    MessageBox.Show("Please enter a valid positive Book ID.");
                    return;
                }

                try
                {
                    await LoadBorrowedBooksById(bookId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading borrowed books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric Book ID.");
            }
        }

        private async Task LoadBorrowedBooksById(int? bookId)
        {
            string query = "SELECT b.BookID, b.Title, b.Author, bb.DateBorrowed, bb.DueDate FROM Books b " +
                           "JOIN BorrowedBooks bb ON b.BookID = bb.BookID " +
                           "WHERE b.BookID = @BookID AND bb.ReturnedDate IS NULL";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        ReturnBookDataGrid.DataSource = dataTable;
                    }
                }
            }

            if (ReturnBookDataGrid.Rows.Count == 0)
            {
                MessageBox.Show("No borrowed books found for the provided Book ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task LoadBorrowedBooksAsync(int studentId)
        {
            string query = "SELECT b.BookID, b.Title, b.Author, bb.DateBorrowed, bb.DueDate FROM Books b " +
                           "JOIN BorrowedBooks bb ON b.BookID = bb.BookID " +
                           "WHERE bb.StudentID = @StudentID AND bb.ReturnedDate IS NULL";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        ReturnBookDataGrid.DataSource = dataTable;
                    }
                }
            }
        }

        private async void ReturnBookBtn_Click(object sender, EventArgs e)
        {
            // Check if ReturnBookDataGrid and its DataSource are initialized
            if (ReturnBookDataGrid == null || ReturnBookDataGrid.DataSource == null || !(ReturnBookDataGrid.DataSource is DataTable dataTable))
            {
                MessageBox.Show("No books available to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                List<int> selectedBookIds = new List<int>();

                foreach (DataGridViewRow row in ReturnBookDataGrid.Rows)
                {
                    // Check if the checkbox cell is not null and is checked
                    DataGridViewCheckBoxCell chk = row.Cells["chkSelect"] as DataGridViewCheckBoxCell;
                    if (chk != null && Convert.ToBoolean(chk.Value))
                    {
                        int bookId;
                        if (int.TryParse(row.Cells["BookID"].Value.ToString(), out bookId))
                        {
                            selectedBookIds.Add(bookId);
                        }
                    }
                }

                if (selectedBookIds.Count == 0)
                {
                    MessageBox.Show("Please select at least one book to return.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool success = await ReturnBooksAsync(selectedBookIds);

                if (success)
                {
                    await LoadBorrowedBooksAsync(currentStudentId); // Refresh the grid after returning books
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception if needed
            }
        }


        private async Task<bool> ReturnBooksAsync(List<int> bookIds)
        {
            string updateBooksQuery = "UPDATE Books SET IsAvailable = TRUE WHERE BookID = @BookID";
            string updateBorrowedBooksQuery = "UPDATE BorrowedBooks SET ReturnedDate = @ReturnedDate WHERE BookID = @BookID AND ReturnedDate IS NULL";

            List<string> errorMessages = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                await conn.OpenAsync();
                using (MySqlTransaction transaction = await conn.BeginTransactionAsync())
                {
                    try
                    {
                        foreach (int bookId in bookIds)
                        {
                            if (bookId <= 0)
                            {
                                errorMessages.Add($"Invalid BookID: {bookId}");
                                continue;
                            }

                            // Update Books table
                            using (MySqlCommand cmdBooks = new MySqlCommand(updateBooksQuery, conn, transaction))
                            {
                                cmdBooks.Parameters.AddWithValue("@BookID", bookId);
                                int rowsAffectedBooks = await cmdBooks.ExecuteNonQueryAsync();
                                if (rowsAffectedBooks == 0)
                                {
                                    errorMessages.Add($"No rows affected in Books table for BookID {bookId}");
                                }
                            }

                            // Update BorrowedBooks table
                            using (MySqlCommand cmdBorrowed = new MySqlCommand(updateBorrowedBooksQuery, conn, transaction))
                            {
                                cmdBorrowed.Parameters.AddWithValue("@BookID", bookId);
                                cmdBorrowed.Parameters.AddWithValue("@ReturnedDate", DateTime.Now);
                                int rowsAffectedBorrowed = await cmdBorrowed.ExecuteNonQueryAsync();
                                if (rowsAffectedBorrowed == 0)
                                {
                                    errorMessages.Add($"No rows affected in BorrowedBooks table for BookID {bookId}");
                                }
                            }
                        }

                        await transaction.CommitAsync();

                        // If there are errors, display them
                        if (errorMessages.Count > 0)
                        {
                            string errorMessage = string.Join("\n", errorMessages);
                            MessageBox.Show($"Errors occurred while returning books:\n{errorMessage}", "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            await LogAsync($"Errors occurred while returning books:\n{errorMessage}");
                            return false;
                        }
                        else
                        {
                            MessageBox.Show("Books returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        MessageBox.Show($"An error occurred while returning books: {ex.Message}", "Return Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        await LogAsync($"An error occurred while returning books: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private async Task LogAsync(string message)
        {
            await Task.Run(() => MessageBox.Show(message));
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }
    }
}

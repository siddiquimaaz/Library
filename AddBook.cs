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
        public AddBook()
        {
            InitializeComponent();
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

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT BookID, Title, Author, ISBN, PublicationYear, Genre, IsAvailable FROM Books WHERE Title LIKE @Title AND Author LIKE @Author";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Title", $"%{title}%");
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
                            // Run the data loading in the background
                            await Task.Run(() => adapter.Fill(dt));
                            // Ensure that the data source setting happens on the UI thread
                            Invoke(new Action(() => {
                                booksView.DataSource = dt;
                            }));
                        }
                    }
                }
                // Ensure that any UI formatting logic is executed on the UI thread
                Invoke(new Action(() => FormatDataGridView()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridView()
        {
            booksView.AutoGenerateColumns = false;
            booksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ensure the checkbox column for availability is added only once
            if (!booksView.Columns.Contains("IsAvailable"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                {
                    Name = "IsAvailable",
                    HeaderText = "Available?",
                    DataPropertyName = "IsAvailable",
                    Width = 80,
                    ReadOnly = true,  // Should be set to true for consistency
                    FalseValue = "False",
                    TrueValue = "True"
                };
                booksView.Columns.Add(chk);
            }

            UpdateCheckBoxes();  // Make sure this is called after adjusting the columns
        }
        private void UpdateCheckBoxes()
        {
            try
            {
                foreach (DataGridViewRow row in booksView.Rows)
                {
                    if (!row.IsNewRow)  // Skip the new row template
                    {
                        DataGridViewCheckBoxCell chkCell = row.Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                        if (chkCell != null)
                        {
                            bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                            chkCell.ReadOnly = true;  // All cells should be read-only, interaction is through other means
                            chkCell.Value = isAvailable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update checkboxes: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    bool wasBorrowedSuccessfully = await BorrowBookAsync(bookId, row.Index);
                    if (!wasBorrowedSuccessfully)
                    {
                        allSuccessfullyBorrowed = false;
                        row.Cells["IsAvailable"].Value = true; // Revert the checkbox since borrow failed
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
            if (e.RowIndex != -1 && !booksView.Rows[e.RowIndex].IsNewRow &&
                e.ColumnIndex == booksView.Columns["IsAvailable"].Index)
            {
                DataGridViewCheckBoxCell cell = booksView.Rows[e.RowIndex].Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                if (cell != null && !cell.ReadOnly)
                {
                    // Proper casting to avoid CS0023
                    if (cell.Value is bool isChecked)
                    {
                        cell.Value = !isChecked; // Toggle the checkbox state safely

                        if (!isChecked) // If it was unchecked before, now it is checked
                        {
                            int bookId = Convert.ToInt32(booksView.Rows[e.RowIndex].Cells["BookID"].Value);
                            try
                            {
                                await BorrowBookAsync(bookId, e.RowIndex);
                                cell.ReadOnly = true; // Optionally make it readonly to avoid un-borrowing
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to borrow book: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cell.Value = isChecked; // Revert checkbox if operation failed
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Checkbox value is not a boolean", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private async Task<bool> BorrowBookAsync(int bookId, int rowIndex)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        string updateSql = "UPDATE Books SET IsAvailable = false WHERE BookID = @BookId AND IsAvailable = true";
                        using (var updateCmd = new MySqlCommand(updateSql, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@BookId", bookId);
                            updateCmd.Transaction = transaction;
                            int affectedRows = await updateCmd.ExecuteNonQueryAsync();

                            if (affectedRows > 0)
                            {
                                await transaction.CommitAsync();
                                return true;  // Borrowing successful
                            }
                            else
                            {
                                await transaction.RollbackAsync();
                                return false;  // No rows updated, book may already be borrowed
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while borrowing the book: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;  // Exception occurred, borrowing failed
                }
            }
        }



    }
}

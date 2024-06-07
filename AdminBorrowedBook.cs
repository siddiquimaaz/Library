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
    public partial class AdminBorrowedBook : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public AdminBorrowedBook()
        {
            InitializeComponent();
            BorrowBookSearch.Click += new EventHandler(BorrowBookSearch_Click);
            DeleteBoorowBookBtn.Click += new EventHandler(DeleteBoorowBookBtn_Click);
            BorrowedBookAdminPanel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BorrowedBookAdminPanel.MultiSelect = false;
            CustomizeDataGridView();
            this.Load += AdminBorrowedBook_Load;
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private async void DeleteBoorowBookBtn_Click(object? sender, EventArgs? e)
        {
            if (BorrowedBookAdminPanel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book record to delete.");
                return;
            }

            int borrowID = Convert.ToInt32(BorrowedBookAdminPanel.SelectedRows[0].Cells["BorrowID"].Value);

            await DeleteBorrowedBookAsync(borrowID);
        }

        private async Task DeleteBorrowedBookAsync(int borrowID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "DELETE FROM BorrowedBooks WHERE BorrowID = @BorrowID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BorrowID", borrowID);
                        int result = await cmd.ExecuteNonQueryAsync();
                        if (result > 0)
                        {
                            MessageBox.Show("Book record deleted successfully.");
                            await ShowAllBorrowedBooksAsync(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the book record.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async void BorrowBookSearch_Click(object? sender, EventArgs? e)
        {
            string bookName = BorrowedBook.Text;
            if (string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Please enter a book name to search.");
                return;
            }

            int borrowID = await SearchBorrowedBooksAsync(bookName);
            if (borrowID == -1)
            {
                MessageBox.Show($"The book '{bookName}' was not found in the borrowed books list.");
                return;
            }

            // Update the DataGridView to select the row corresponding to the found book
            SelectRowByBorrowID(borrowID);
        }
        private async Task<int> SearchBorrowedBooksAsync(string bookName)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT bb.BorrowID 
                             FROM BorrowedBooks bb
                             JOIN Books b ON bb.BookID = b.BookID
                             WHERE b.Title LIKE @BookName";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookName", "%" + bookName + "%");

                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null && result != DBNull.Value)
                        {
                            // If book is found, return its BorrowID
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            return -1; // Indicates book not found
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return -1;
            }
        }

        private void SelectRowByBorrowID(int borrowID)
        {
            // Iterate through DataGridView rows to find the row with the matching BorrowID
            foreach (DataGridViewRow row in BorrowedBookAdminPanel.Rows)
            {
                try
                {
                    if (row.Cells["BorrowID"].Value != null && row.Cells["BorrowID"].Value != DBNull.Value
                        && Convert.ToInt32(row.Cells["BorrowID"].Value) == borrowID)
                    {
                        // Select the row and scroll it into view
                        row.Selected = true;
                        BorrowedBookAdminPanel.CurrentCell = row.Cells[0];
                        BorrowedBookAdminPanel.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void CustomizeDataGridView()
        {
            BorrowedBookAdminPanel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BorrowedBookAdminPanel.MultiSelect = false;
            BorrowedBookAdminPanel.BorderStyle = BorderStyle.Fixed3D;
            BorrowedBookAdminPanel.BackgroundColor = Color.White;
            BorrowedBookAdminPanel.DefaultCellStyle.SelectionBackColor = Color.Gray;
            BorrowedBookAdminPanel.DefaultCellStyle.SelectionForeColor = Color.Black;
            BorrowedBookAdminPanel.RowHeadersVisible = false;
            BorrowedBookAdminPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Set column headers style
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle
            {
                BackColor = Color.Navy,
                ForeColor = Color.White,
                Font = new Font("Verdana", 10, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            BorrowedBookAdminPanel.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            BorrowedBookAdminPanel.EnableHeadersVisualStyles = false; // Apply custom header styles
        }



        private void AddEmptyRowForSpacing(DataTable dataTable)
        {
            // Add an empty row at the top for spacing
            DataRow emptyRow = dataTable.NewRow();
            dataTable.Rows.InsertAt(emptyRow, 0);
        }

        private async void AdminBorrowedBook_Load(object sender, EventArgs e)
        {

            await ShowAllBorrowedBooksAsync();
        }

        private async Task ShowAllBorrowedBooksAsync()
        {
            await SearchBorrowedBooksAsync("");
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = @"SELECT bb.BorrowID, b.Title, s.FirstName, s.LastName, bb.DateBorrowed, bb.DueDate 
                             FROM BorrowedBooks bb
                             JOIN Books b ON bb.BookID = b.BookID
                             JOIN Students s ON bb.StudentID = s.StudentID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Add an empty row for spacing
                        AddEmptyRowForSpacing(dataTable);

                        BorrowedBookAdminPanel.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void BorrowBookBackBtn_Click(object sender, EventArgs e)
        {
            FormManager.Show(new adminpanel());
        }

        private void BorrowedBookAdminPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

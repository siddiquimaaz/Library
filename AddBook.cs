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
            LoadBooks();
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
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }
        private void SearchBooks()
        {
            string title = booktitltxt.Text.Trim();
            string author = authortxt.Text.Trim();

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT BookID, Title, Author, ISBN, PublicationYear, Genre, IsAvailable FROM Books WHERE Title LIKE @Title AND Author LIKE @Author";

                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Title", $"%{title}%");
                        cmd.Parameters.AddWithValue("@Author", $"%{author}%");

                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            booksView.DataSource = dt;

                            // Provide feedback if no books are found
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
                MessageBox.Show($"An error occurred while searching for books: {ex.Message}");
            }
        }


        private void LoadBooks()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT BookID, Title, Author, ISBN, PublicationYear, Genre, IsAvailable FROM Books";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                            booksView.DataSource = dt;
                        }
                    }
                }
                FormatDataGridView(); // Ensure formatting is applied after data is loaded
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}");
            }
        }

        private void addToStdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (booksView.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = booksView.SelectedRows[0];
                    bool isBookAvailable = Convert.ToBoolean(selectedRow.Cells["IsAvailable"].Value);

                    if (isBookAvailable)
                    {
                        int bookId = Convert.ToInt32(selectedRow.Cells["BookID"].Value);
                        BorrowBook(bookId, selectedRow.Index);
                    }
                    else
                    {
                        MessageBox.Show("This book is currently not available.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a book to borrow.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error borrowing book: {ex.Message}");
            }
        }

        private void FormatDataGridView()
        {
            booksView.AutoGenerateColumns = false;
            booksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!booksView.Columns.Contains("IsAvailable"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn
                {
                    Name = "IsAvailable",
                    HeaderText = "Available?",
                    DataPropertyName = "IsAvailable",
                    Width = 80,
                    ReadOnly = true,  // Always read-only, we do not interact with this directly
                    FalseValue = false,
                    TrueValue = true
                };
                booksView.Columns.Add(chk);
            }
            // Initialize the grid to reflect current data
            UpdateCheckBoxes();
        }

        private void UpdateCheckBoxes()
        {
            foreach (DataGridViewRow row in booksView.Rows)
            {
                bool isAvailable = Convert.ToBoolean(row.Cells["IsAvailable"].Value);
                DataGridViewCheckBoxCell chkCell = row.Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                chkCell.ReadOnly = true;  // Always read-only, interaction is done through button
            }
        }


        private void booksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == booksView.Columns["IsAvailable"].Index && e.RowIndex != -1)
            {
                DataGridViewCheckBoxCell cell = booksView.Rows[e.RowIndex].Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                if (!cell.ReadOnly)
                {
                    bool isChecked = Convert.ToBoolean(cell.Value);
                    if (!isChecked)
                    {
                        int bookId = Convert.ToInt32(booksView.Rows[e.RowIndex].Cells["BookID"].Value);
                        BorrowBook(bookId, e.RowIndex);
                        cell.ReadOnly = true;  // Make the checkbox readonly after borrowing
                    }
                }
            }
        }

        private void BorrowBook(int bookId, int rowIndex)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Books SET IsAvailable = false WHERE BookID = @BookId";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookId", bookId);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Book successfully borrowed.");
                            booksView.Rows[rowIndex].Cells["IsAvailable"].Value = false;
                            booksView.Refresh(); // Refresh to show changes
                        }
                        else
                        {
                            MessageBox.Show("Failed to borrow the book.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error borrowing book: {ex.Message}");
            }
        }


    }
}

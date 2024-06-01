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
using System.Drawing.Drawing2D;

namespace Library
{
    public partial class AddBook : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        private int currentStudentId;  // Field to store the current student's ID

        public AddBook()
        {
            InitializeComponent();
            currentStudentId = Form1.SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo
            Task.Run(async () => await InitializeFormAsync()).Wait();
            FormManager.Show(this); // Use FormManager to show the form
        }
        private async Task InitializeFormAsync()
        {
            try
            {
                await FetchAndDisplayStudentInfo(currentStudentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task<int> GetStudentId(string username)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT StudentID FROM Students WHERE Username = @Username";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = await cmd.ExecuteScalarAsync();
                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {
                            throw new Exception("User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving student ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private async Task FetchAndDisplayStudentInfo(int studentId)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT FirstName, LastName, Photo FROM Students WHERE StudentId = @StudentId";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync()) // Ensure there's data to read
                        {
                            // Casting DbDataReader to MySqlDataReader
                            DisplayStudentInfo((MySqlDataReader)reader);
                        }
                        else
                        {
                            MessageBox.Show("No student data found.");
                        }
                    }
                }
            }
        }
        private async void AddBook_Load(object sender, EventArgs e)
        {
            await FetchAndDisplayStudentInfo(currentStudentId); // Pass the student ID
            await LoadBooksAsync(); // Load books when the form is loaded
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new home());
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            booktitltxt.Text = "";
            authortxt.Text = "";
            FormManager.CloseCurrentForm(); // Close the current form
            FormManager.Show(new home()); // Show the existing home form

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
                            booksView.Invoke(new Action(() =>
                            {
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

                // Add columns in the desired order
                AddColumnIfMissing("Title", "Title");
                AddColumnIfMissing("Author", "Author");
                AddColumnIfMissing("ISBN", "ISBN");
                AddColumnIfMissing("PublicationYear", "Year", "Year");
                AddColumnIfMissing("Genre", "Genre");
                AddCheckboxColumnIfMissing("IsAvailable", "Available?", "IsAvailable");

                // Adjust column widths
                booksView.Columns["Title"].Width = 160; // Adjust width for the Title column
                booksView.Columns["Author"].Width = 100;
                booksView.Columns["ISBN"].Width = 80;
                booksView.Columns["Genre"].Width = 60; // Adjust width for the Genre column

                // Hide the empty ID column
                //booksView.Columns["BookID"].Visible = false;

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
                        MessageBox.Show($"Error borrowing book ID {bookId}: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (!anyBookSelected)
            {
                MessageBox.Show("Please select at least one available book to borrow.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (allSuccessfullyBorrowed)
            {
                MessageBox.Show("All selected books have been successfully borrowed.", "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Some selected books could not be borrowed.", "Partial Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            booksView.Refresh();
            await LoadBooksAsync(); // Refresh the list of books after borrowing
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
            bool isAvailable;
            int currentStudentId = Form1.SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo

            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Check if the book is still available
                using (var cmdCheckAvailability = new MySqlCommand("SELECT IsAvailable FROM Books WHERE BookID = @BookID", connection))
                {
                    cmdCheckAvailability.Parameters.AddWithValue("@BookID", bookId);
                    var result = await cmdCheckAvailability.ExecuteScalarAsync();
                    isAvailable = result != DBNull.Value && Convert.ToBoolean(result);
                }

                if (!isAvailable)
                {
                    this.Invoke((MethodInvoker)(() =>
                        MessageBox.Show($"Book with ID {bookId} is no longer available.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ));
                    return false; // Indicate that borrowing failed
                }

                // If available, proceed to borrow
                using (var transaction = await connection.BeginTransactionAsync())
                {
                    try
                    {
                        // Update the book status
                        using (var cmdUpdateBook = new MySqlCommand("UPDATE Books SET IsAvailable = 0 WHERE BookID = @BookID", connection, transaction))
                        {
                            cmdUpdateBook.Parameters.AddWithValue("@BookID", bookId);
                            await cmdUpdateBook.ExecuteNonQueryAsync();
                        }

                        // Record the borrowing
                        using (var cmdInsertBorrowing = new MySqlCommand("INSERT INTO BorrowedBooks (StudentID, BookID, DateBorrowed, DueDate) VALUES (@StudentID, @BookID, @DateBorrowed, @DueDate)", connection, transaction))
                        {
                            cmdInsertBorrowing.Parameters.AddWithValue("@StudentID", currentStudentId);
                            cmdInsertBorrowing.Parameters.AddWithValue("@BookID", bookId);
                            cmdInsertBorrowing.Parameters.AddWithValue("@DateBorrowed", DateTime.Now);
                            cmdInsertBorrowing.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(14)); // Assuming a 2-week borrowing period
                            await cmdInsertBorrowing.ExecuteNonQueryAsync();
                        }

                        await transaction.CommitAsync();
                        return true; // Indicate that borrowing was successful
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        this.Invoke((MethodInvoker)(() =>
                            MessageBox.Show($"Failed to borrow book ID {bookId}: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        ));
                        return false; // Indicate that borrowing failed
                    }
                }
            }
        }


        private void DisplayStudentInfo(MySqlDataReader reader)
        {
            string firstName = reader["FirstName"].ToString();
            string lastName = reader["LastName"].ToString();
            byte[] photoBytes = reader["Photo"] as byte[];

            addbookstdname.Text = $"{firstName} {lastName}";

            if (photoBytes != null && photoBytes.Length > 0)
            {
                using (var ms = new MemoryStream(photoBytes))
                {
                    Image originalImage = Image.FromStream(ms);
                    addbookstdname.Visible = true;
                    addbookstdimage.Visible = true;
                    addbookstdimage.Image = GetEllipseImage(originalImage);
                }
            }
            else
            {
                MessageBox.Show("Student image not found.");
            }
        }


        private Image GetEllipseImage(Image originalImage)
        {
            Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Transparent);
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, originalImage.Width, originalImage.Height);
                g.SetClip(path);
                g.DrawImage(originalImage, 0, 0);
            }

            return bitmap;
        }

        

        
    }
}

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
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=Zain1234;";
        //string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        private int currentStudentId;  // Field to store the current student's ID
        private List<Book> books = new List<Book>();

        public AddBook()
        {
            FormManager.AttachUserActivityHandlers(this);
            InitializeComponent();
            currentStudentId = SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo

            // Ensure the form handle is created before proceeding
            this.HandleCreated += async (s, e) =>
            {
                try
                {
                    await InitializeFormAsync();
                    FormManager.Show(this); // Use FormManager to show the form
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during form initialization: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Additional event handler for the form load, if needed
            this.Load += async (s, e) =>
            {
                try
                {
                    await LoadBooksAsync();
                    LoadUserData(); // Pass the student ID
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading student info: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
        }

        private async Task InitializeFormAsync()
        {
            try
            {
                //Not-Neccessary
                //await LoadBooksAsync(); // Always reload books to refresh the grid, ensuring consistency with the database
            }
            catch (Exception ex)
            {
                // Ensure any UI updates are invoked on the main thread
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                        MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
                }
                else
                {
                    MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private async void AddBook_Load(object? sender, EventArgs? e)
        {
            LoadUserData();
            FormManager.AttachUserActivityHandlers(this);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new home());
        }

        private async void cancel_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            booktitltxt.Text = "";
            authortxt.Text = "";
            await LoadBooksAsync();
            booksView.Refresh();

        }

        private void SearchBtn_Click(object? sender, EventArgs? e)
        {
            FormManager.RecordUserActivity();
            SearchBooksAsync();
        }
        private async void LoadUserData()
        {
            try
            {
                int userId = SessionInfo.CurrentStudentId; // Access the user ID from SessionInfo
                if (userId != -1)
                {
                    await StudentInfo.Instance.LoadStudentInfoAsync(userId, connectionString);
                    DisplayStudentInfo(); // Display the loaded student info
                }
                else
                {
                    MessageBox.Show("User ID is invalid or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task SearchBooksAsync()
        {
            string title = booktitltxt.Text.Trim();
            string author = authortxt.Text.Trim();

            var filters = new List<string>();
            if (!string.IsNullOrEmpty(title))
                filters.Add("Title LIKE @Title");
            if (!string.IsNullOrEmpty(author))
                filters.Add("Author LIKE @Author");

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
                            booksView.Invoke(new Action(async () =>
                            {
                                booksView.DataSource = dt;
                                await SetupDataGridViewAsync();
                                UpdateCheckBoxes();
                            }));
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
                    string sql = "SELECT BookID, Title, Author, ISBN, PublicationYear, Genre FROM Books"; // Removed IsAvailable
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(dt));
                            books = ConvertDataTableToList(dt);
                            booksView.DataSource = books;
                            await SetupDataGridViewAsync();

                            // Update availability status concurrently
                            await UpdateAvailabilityStatusConcurrently();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Book> ConvertDataTableToList(DataTable dt)
        {
            List<Book> list = new List<Book>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Book
                {
                    BookID = Convert.ToInt32(row["BookID"]),
                    Title = row["Title"].ToString(),
                    Author = row["Author"].ToString(),
                    ISBN = row["ISBN"].ToString(),
                    PublicationYear = Convert.ToInt32(row["PublicationYear"]),
                    Genre = row["Genre"].ToString(),
                    IsAvailable = false // Default to false, will update later
                });
            }
            return list;
        }


        private async Task SetupDataGridViewAsync()
        {
            try
            {
                FormManager.RecordUserActivity();
                booksView.AutoGenerateColumns = false;
                booksView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                booksView.ReadOnly = false; // Allow editing for checkboxes

                AddColumnIfMissing("Title", "Title");
                AddColumnIfMissing("Author", "Author");
                AddColumnIfMissing("ISBN", "ISBN");
                AddColumnIfMissing("PublicationYear", "Year");
                AddColumnIfMissing("Genre", "Genre");
                AddCheckboxColumnIfMissing("IsAvailable", "Available?", "IsAvailable");

                booksView.Columns["Title"].ReadOnly = true;
                booksView.Columns["Author"].ReadOnly = true;
                booksView.Columns["ISBN"].ReadOnly = true;
                booksView.Columns["PublicationYear"].ReadOnly = true;
                booksView.Columns["Genre"].ReadOnly = true;
                booksView.Columns["IsAvailable"].ReadOnly = false; // Allow editing for this column only

                await UpdateAvailabilityStatusConcurrently(); // Ensure availability is updated before displaying
                booksView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up data grid view: {ex.Message}", "UI Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateAvailabilityStatusConcurrently()
        {
            try
            {
                var tasks = books.Select(book => Task.Run(() =>
                {
                    book.IsAvailable = GetBookAvailabilityFromDatabase(book.BookID);
                })).ToArray();

                await Task.WhenAll(tasks);
                UpdateCheckBoxes(); // Ensure checkboxes are updated after fetching availability
                booksView.Invoke(new Action(() => booksView.Refresh()));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update availability status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (row.DataBoundItem is Book book)
                    {
                        DataGridViewCheckBoxCell chkCell = row.Cells["IsAvailable"] as DataGridViewCheckBoxCell;
                        if (chkCell != null)
                        {
                            chkCell.Value = book.IsAvailable;
                            chkCell.ReadOnly = !book.IsAvailable; // Set to read-only if not available
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update checkboxes: {ex.Message}", "Checkbox Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booksView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormManager.RecordUserActivity();
                if (e.ColumnIndex == booksView.Columns["IsAvailable"].Index && e.RowIndex >= 0)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)booksView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    bool isChecked = Convert.ToBoolean(cell.Value);

                    if (cell.ReadOnly)
                    {
                        MessageBox.Show("This book is currently not available and cannot be changed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        cell.Value = !isChecked;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to handle cell click: {ex.Message}", "Cell Click Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GetBookAvailabilityFromDatabase(int bookID)
        {
            try
            {
                FormManager.RecordUserActivity();
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the book is borrowed and not returned
                    string sql = "SELECT COUNT(*) FROM BorrowedBooks WHERE BookID = @BookID AND ReturnedDate IS NULL";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        int borrowedCount = Convert.ToInt32(cmd.ExecuteScalar());
                        return borrowedCount == 0; // Book is available if not borrowed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to check book availability: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Default to false if there is an error
            }
        }

        private async void addToStdbtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            booksView.Refresh();
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
                        }
                    }
                    catch (Exception ex)
                    {
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
                MessageBox.Show("Books borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadBooksAsync();
            }
            else
            {
                MessageBox.Show("Some books could not be borrowed.", "Partial Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async Task<bool> BorrowBookAsync(int bookId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        try
                        {
                            // Check if the book is already borrowed
                            string checkAvailabilityQuery = "SELECT COUNT(*) FROM BorrowedBooks WHERE BookID = @BookID AND ReturnedDate IS NULL";
                            using (var checkCmd = new MySqlCommand(checkAvailabilityQuery, connection, transaction))
                            {
                                checkCmd.Parameters.AddWithValue("@BookID", bookId);
                                int count = Convert.ToInt32(await checkCmd.ExecuteScalarAsync());
                                if (count > 0)
                                {
                                    MessageBox.Show($"Book ID {bookId} is already borrowed.", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return false;
                                }
                            }

                            // Calculate due date (2 days from now)
                            DateTime dueDate = DateTime.Now.AddDays(2);

                            // Insert a new record into BorrowedBooks
                            string borrowQuery = "INSERT INTO BorrowedBooks (StudentID, BookID, DateBorrowed, DueDate) VALUES (@StudentID, @BookID, @DateBorrowed, @DueDate)";
                            using (var borrowCmd = new MySqlCommand(borrowQuery, connection, transaction))
                            {
                                borrowCmd.Parameters.AddWithValue("@StudentID", currentStudentId);
                                borrowCmd.Parameters.AddWithValue("@BookID", bookId);
                                borrowCmd.Parameters.AddWithValue("@DateBorrowed", DateTime.Now);
                                borrowCmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddMinutes(5));
                                //borrowCmd.Parameters.AddWithValue("@DueDate", dueDate);

                                await borrowCmd.ExecuteNonQueryAsync();
                            }

                            // Update the Books table to mark the book as unavailable
                            string updateBooksQuery = "UPDATE Books SET IsAvailable = FALSE WHERE BookID = @BookID";
                            using (var updateCmd = new MySqlCommand(updateBooksQuery, connection, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@BookID", bookId);
                                await updateCmd.ExecuteNonQueryAsync();
                            }

                            await transaction.CommitAsync();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            await transaction.RollbackAsync();
                            MessageBox.Show($"Error borrowing book ID {bookId}: {ex.Message}", "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void DisplayStudentInfo()
        {
            var studentInfo = StudentInfo.Instance;

            addbookstdname.Text = $"{studentInfo.FirstName} {studentInfo.LastName}";

            if (studentInfo.Photo != null && studentInfo.Photo.Length > 0)
            {
                using (var ms = new MemoryStream(studentInfo.Photo))
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

        private void booksView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void booktitltxt_TextChanged(object sender, EventArgs e) { }

        private void AddBookByReaderCloseLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e){}
    }
}

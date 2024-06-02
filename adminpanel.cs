using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;

namespace Library
{
    public partial class adminpanel : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public adminpanel()
        {
            InitializeComponent();
            this.Load += adminpanel_Load;
            ShowBorrrwedBookAdmin.Click += async (s, e) => await iconButton4_Click(s, e);
        }

        public class BorrowedBookDetails
        {
            public int BorrowID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public DateTime DateBorrowed { get; set; }
            public DateTime DueDate { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminpic_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async Task iconButton4_Click(object sender, EventArgs e)
        {
            await LoadBorrowedBooksWithStudentDetailsAsync();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private async void adminpanel_Load(object sender, EventArgs e)
        {
            await LoadBorrowedBooksWithStudentDetailsAsync();
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
        }

        private async Task LoadAllStudentsAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var query = "SELECT * FROM Students";
                    using (var command = new MySqlCommand(query, connection))
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        adminDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadBorrowedBooksWithStudentDetailsAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var query = @"
                SELECT bb.BorrowID, s.FirstName, s.LastName, s.Email, s.PhoneNumber, b.Title, b.Author, bb.DateBorrowed, bb.DueDate 
                FROM BorrowedBooks bb
                INNER JOIN Students s ON bb.StudentID = s.StudentID
                INNER JOIN Books b ON bb.BookID = b.BookID";

                    using (var command = new MySqlCommand(query, connection))
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        var borrowedBooks = new List<BorrowedBookDetails>();  // Assuming you have a BorrowedBookDetails class
                        while (await reader.ReadAsync())
                        {
                            borrowedBooks.Add(new BorrowedBookDetails
                            {
                                BorrowID = reader.GetInt32("BorrowID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Email = reader.GetString("Email"),
                                PhoneNumber = reader.GetString("PhoneNumber"),
                                Title = reader.GetString("Title"),
                                Author = reader.GetString("Author"),
                                DateBorrowed = reader.GetDateTime("DateBorrowed"),
                                DueDate = reader.GetDateTime("DueDate")
                            });
                        }
                        adminDataGridView.DataSource = borrowedBooks;  // Bind to your DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading borrowed books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AddNewStudentAsync(string firstName, string lastName, string email, string password, string phoneNumber, byte[] photo)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var hashedPassword = HashPassword(password); // Implement password hashing as per your preference

                    var query = @"INSERT INTO Students (FirstName, LastName, Email, HashedPassword, PhoneNumber, Photo)
                          VALUES (@FirstName, @LastName, @Email, @HashedPassword, @PhoneNumber, @Photo)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Photo", photo);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            // Implement your hashing logic here
            return password; // Placeholder
        }
        private async Task AddNewBookAsync(string title, string author, string isbn, int publicationYear, string genre, bool isAvailable)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var query = @"INSERT INTO Books (Title, Author, ISBN, PublicationYear, Genre, IsAvailable)
                          VALUES (@Title, @Author, @ISBN, @PublicationYear, @Genre, @IsAvailable)";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Author", author);
                        command.Parameters.AddWithValue("@ISBN", isbn);
                        command.Parameters.AddWithValue("@PublicationYear", publicationYear);
                        command.Parameters.AddWithValue("@Genre", genre);
                        command.Parameters.AddWithValue("@IsAvailable", isAvailable);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllStdBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanelBackBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

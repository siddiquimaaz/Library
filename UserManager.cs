using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class UserManager
    {
        private string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public async Task<int> RegisterUserAsync(string firstName, string lastName, string email, string hashedPassword, string phoneNumber, byte[] image)
        {
            int studentId = 0;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"INSERT INTO Students 
                                            (FirstName, LastName, Email, HashedPassword, PhoneNumber, Photo, MembershipExpiration) 
                                            VALUES (@FirstName, @LastName, @Email, @HashedPassword, @PhoneNumber, @Photo, @MembershipExpiration)";
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Photo", image ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MembershipExpiration", DateTime.Now.AddDays(1)); // Membership expiration set to 1 day

                        await cmd.ExecuteNonQueryAsync();
                        studentId = (int)cmd.LastInsertedId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to insert student data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            return studentId;
        }

        public async Task DeleteExpiredMembershipsAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "DELETE FROM Students WHERE MembershipExpiration <= @CurrentTime";
                        cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete expired memberships: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async Task ReturnOverdueBooksAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string selectOverdueBooksQuery = @"SELECT BookID, StudentID FROM BorrowedBooks 
                                               WHERE DueDate <= @CurrentTime AND ReturnedDate IS NULL";

                    List<(int bookId, int studentId)> overdueBooks = new List<(int, int)>();

                    using (var cmd = new MySqlCommand(selectOverdueBooksQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@CurrentTime", DateTime.Now);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int bookId = reader.GetInt32("BookID");
                                int studentId = reader.GetInt32("StudentID");
                                overdueBooks.Add((bookId, studentId));
                            }
                        }
                    }

                    if (overdueBooks.Count > 0)
                    {
                        MessageBox.Show($"Collected {overdueBooks.Count} overdue books. Returning them now...");
                    }
                    else
                    {
                        MessageBox.Show("No overdue books found.");
                    }

                    foreach (var overdueBook in overdueBooks)
                    {
                        await ReturnAndSetBookAvailableAsync(connection, overdueBook.bookId, overdueBook.studentId);
                    }

                    if (overdueBooks.Count > 0)
                    {
                        MessageBox.Show("Successfully returned all overdue books and updated their availability.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error returning overdue books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async Task ReturnAndSetBookAvailableAsync(MySqlConnection connection, int bookId, int studentId)
        {
            using (var transaction = await connection.BeginTransactionAsync())
            {
                try
                {
                    string returnBookQuery = "UPDATE BorrowedBooks SET ReturnedDate = @ReturnedDate WHERE BookID = @BookID AND StudentID = @StudentID AND ReturnedDate IS NULL";

                    using (var returnCmd = new MySqlCommand(returnBookQuery, connection, transaction))
                    {
                        returnCmd.Parameters.AddWithValue("@ReturnedDate", DateTime.Now);
                        returnCmd.Parameters.AddWithValue("@BookID", bookId);
                        returnCmd.Parameters.AddWithValue("@StudentID", studentId);

                        await returnCmd.ExecuteNonQueryAsync();
                    }

                    string updateBooksQuery = "UPDATE Books SET IsAvailable = TRUE WHERE BookID = @BookID";

                    using (var updateCmd = new MySqlCommand(updateBooksQuery, connection, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@BookID", bookId);
                        await updateCmd.ExecuteNonQueryAsync();
                    }

                    await transaction.CommitAsync();
                }
                catch (Exception)
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}

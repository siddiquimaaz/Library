using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class UserManager
    {
        private readonly string _connectionString;

        public UserManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<int> RegisterUserAsync(string firstName, string lastName, string email, string hashedPassword, string phoneNumber, byte[] image)
        {
            int studentId = 0;
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"INSERT INTO Students 
                                            (FirstName, LastName, Email, HashedPassword, PhoneNumber, Photo, MembershipExpiration) 
                                            VALUES (@FirstName, @LastName, @Email, @HashedPassword, @PhoneNumber, @Photo, @MembershipExpiration)";
                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@HashedPassword", hashedPassword);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Photo", image ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@MembershipExpiration", DateTime.Now.AddMinutes(5)); // 5-minute session

                        await cmd.ExecuteNonQueryAsync();
                        studentId = Convert.ToInt32(cmd.LastInsertedId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to insert student data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
            return studentId;
        }

        public async Task DeleteExpiredMembershipsAsync()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete expired memberships: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}

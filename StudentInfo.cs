using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class StudentInfo
    {
        //private string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public byte[] Photo { get; private set; }
        private static readonly Lazy<StudentInfo> instance = new Lazy<StudentInfo>(() => new StudentInfo());
        private static readonly object loadLock = new object();
        private bool isLoaded = false;

        private StudentInfo() { }

        public static StudentInfo Instance => instance.Value;

        public async Task LoadStudentInfoAsync(int userId, string connectionString)
        {
            if (isLoaded) return;

            lock (loadLock)
            {
                if (isLoaded) return;
            }

            try
            {
                string sql = "SELECT FirstName, LastName, Photo FROM Students WHERE StudentID = @StudentId";

                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", userId);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                FirstName = reader["FirstName"].ToString();
                                LastName = reader["LastName"].ToString();
                                Photo = reader["Photo"] as byte[];
                                lock (loadLock)
                                {
                                    isLoaded = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Student information not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the exception here.
            }
        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace Library
{
    public static class FormManager
    {
        private static Form currentForm;
        private static int currentStudentId;
        private static DateTime membershipExpiration;

        public static void Show(Form newForm)
        {
            if (currentForm != null && currentForm != newForm)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            currentForm.FormClosed += (sender, e) => currentForm = null;
            newForm.Show();
        }

        public static void CloseCurrentForm()
        {
            if (currentForm != null)
            {
                var tempForm = currentForm;
                currentForm = null;
                tempForm.Close();
            }
        }

        public static void SetSession(int studentId, DateTime expirationDate)
        {
            currentStudentId = studentId;
            membershipExpiration = expirationDate;
            StartExpirationCheck();
        }

        public static bool IsSessionActive()
        {
            return currentStudentId != 0 && DateTime.Now < membershipExpiration;
        }

        public static bool IsMembershipExpiring(int daysBeforeExpiration)
        {
            TimeSpan remainingTime = membershipExpiration - DateTime.Now;
            return remainingTime.TotalMinutes <= daysBeforeExpiration && remainingTime.TotalMinutes >= 0;
        }

        public static void NotifyExpiration(int minutesBeforeExpiration)
        {
            if (IsMembershipExpiring(minutesBeforeExpiration))
            {
                MessageBox.Show($"Your membership is expiring in {minutesBeforeExpiration} minutes.", "Membership Expiration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void ClearSession()
        {
            currentStudentId = 0;
            membershipExpiration = DateTime.MinValue;
        }

        private static async void StartExpirationCheck()
        {
            while (true)
            {
                await Task.Delay(60000); // Check every minute

                if (!IsSessionActive())
                {
                    MessageBox.Show("Your membership has expired.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RemoveUserFromDatabaseAsync();
                    CloseAllForms();
                    ClearSession();
                    break;
                }
                else
                {
                    NotifyExpiration(1); // Notify 1 minute before expiration for testing purposes
                }
            }
        }

        private static async Task RemoveUserFromDatabaseAsync()
        {
            string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string query = "DELETE FROM Students WHERE StudentID = @StudentID";

                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", currentStudentId);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing user from the database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void CloseAllForms()
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Invoke((Action)(() => form.Close()));
            }
        }
    }
}

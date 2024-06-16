using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Timers;

namespace Library
{
    public static class FormManager
    {
        private static Form currentForm;
        private static int currentStudentId;
        private static DateTime membershipExpiration;
        private static System.Timers.Timer inactivityTimer;
        private static DateTime lastActivityTime;
        private const int InactivityLimitMinutes = 2; // Inactivity limit in minutes for testing purposes
        private const int MembershipExpirationDays = 1; // Membership expiration duration in days for testing purposes

        static FormManager()
        {
            inactivityTimer = new System.Timers.Timer(60000); // Check every minute
            inactivityTimer.Elapsed += OnInactivityCheck;
        }

        public static void Show(Form newForm)
        {
            if (currentForm != null && currentForm != newForm)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            currentForm.FormClosed += (sender, e) => currentForm = null;
            newForm.Show();
            ResetInactivityTimer();
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
            membershipExpiration = expirationDate.AddMinutes(InactivityLimitMinutes); // Set membership expiration with inactivity limit
            StartExpirationCheck();
            StartInactivityTimer();
            ResetInactivityTimer();
        }

        public static bool IsSessionActive()
        {
            return currentStudentId != 0 && DateTime.Now < membershipExpiration;
        }

        public static bool IsMembershipExpiring(int daysBeforeExpiration)
        {
            TimeSpan remainingTime = membershipExpiration - DateTime.Now;
            return remainingTime.TotalDays <= daysBeforeExpiration && remainingTime.TotalDays >= 0;
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
            StopInactivityTimer();
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
                    await CloseAllFormsAsync();
                    ClearSession();
                    break;
                }
                else
                {
                    NotifyExpiration(1); // Notify 1 minute before expiration for testing purposes
                }
            }
        }

        private static void StartInactivityTimer()
        {
            inactivityTimer.Start();
        }

        private static void StopInactivityTimer()
        {
            inactivityTimer.Stop();
        }

        private static void ResetInactivityTimer()
        {
            lastActivityTime = DateTime.Now;
        }

        private static void OnInactivityCheck(object sender, ElapsedEventArgs e)
        {
            if ((DateTime.Now - lastActivityTime).TotalMinutes >= InactivityLimitMinutes)
            {
                MessageBox.Show("You have been inactive for too long. Session will be terminated.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CloseAllFormsAsync();
                ClearSession();
                inactivityTimer.Stop();
            }
        }

        public static void RecordUserActivity()
        {
            ResetInactivityTimer();
        }

        private static async Task RemoveUserFromDatabaseAsync()
        {
            //string connectionString = "server=127.0.0.1;port=3306;database=LMS;uid=root;pwd=maazsiddiqui12;";
            string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

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

        private static async Task CloseAllFormsAsync()
        {
            try
            {
                List<Form> openForms = new List<Form>();

                // Copy the list of open forms to avoid collection modified exceptions
                foreach (Form form in Application.OpenForms)
                {
                    openForms.Add(form);
                }

                // Close each form safely asynchronously
                foreach (Form form in openForms)
                {
                    if (form.InvokeRequired)
                    {
                        await form.Invoke(async () =>
                        {
                            await CloseFormSafelyAsync(form);
                        });
                    }
                    else
                    {
                        await CloseFormSafelyAsync(form);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"Error closing forms: {ex.Message}");
            }
        }

        private static async Task CloseFormSafelyAsync(Form form)
        {
            try
            {
                await Task.Run(() =>
                {
                    form.Close();
                });
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"Error closing form {form.Name}: {ex.Message}");
            }
        }

    }

}

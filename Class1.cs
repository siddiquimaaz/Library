﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public static class FormManager
    {
        private static Form currentForm;
        private static int currentStudentId;
        private static DateTime membershipExpiration;
        private static System.Timers.Timer inactivityTimer;
        private static DateTime lastActivityTime;
        private static System.Timers.Timer membershipCheckTimer;
        private static System.Timers.Timer overdueBooksCheckTimer;
        private const int InactivityLimitMinutes = 10; // Inactivity limit in minutes (for testing)
        private const int MembershipExpirationDays = 1; // Membership expiration duration in days
        private static UserManager userManager;

        static FormManager()
        {
            inactivityTimer = new System.Timers.Timer(60000); // Check inactivity every minute
            inactivityTimer.Elapsed += OnInactivityCheck;

            membershipCheckTimer = new System.Timers.Timer(60000); // Check membership expiration every minute
            membershipCheckTimer.Elapsed += OnMembershipCheck;
            membershipCheckTimer.Start(); // Start membership check timer

            overdueBooksCheckTimer = new System.Timers.Timer(60000); // Check for overdue books every minute
            overdueBooksCheckTimer.Elapsed += OnOverdueBooksCheck;
            overdueBooksCheckTimer.Start(); // Start overdue books check timer

            userManager = new UserManager();
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

        public static void SetSession(int studentId)
        {
            currentStudentId = studentId;
            membershipExpiration = DateTime.Now.AddDays(MembershipExpirationDays); // Set membership expiration to 1 day from now
            Console.WriteLine($"Session started for student {studentId}, membership expires at {membershipExpiration}");
            StartExpirationCheck();
            StartInactivityTimer();
            ResetInactivityTimer();
        }

        public static bool IsSessionActive()
        {
            return currentStudentId != 0 && IsMembershipActive();
        }

        public static bool IsMembershipActive()
        {
            bool isActive = DateTime.Now < membershipExpiration;
            Console.WriteLine($"Membership active: {isActive}, current time: {DateTime.Now}, membership expiration: {membershipExpiration}");
            return isActive;
        }

        public static bool IsMembershipExpiring(int minutesBeforeExpiration)
        {
            TimeSpan remainingTime = membershipExpiration - DateTime.Now;
            return remainingTime.TotalMinutes <= minutesBeforeExpiration && remainingTime.TotalMinutes >= 0;
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
            while (IsSessionActive())
            {
                await Task.Delay(60000); // Check every minute

                if (!IsSessionActive())
                {
                    MessageBox.Show("Your Session has been expired.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CloseAllFormsAsync().GetAwaiter().GetResult();
                ClearSession();
                inactivityTimer.Stop();
            }
        }

        private static async void OnMembershipCheck(object sender, ElapsedEventArgs e)
        {
            await userManager.DeleteExpiredMembershipsAsync();
            if (!IsMembershipActive())
            {
                MessageBox.Show("Your membership has expired.", "Session Expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSession();
                await CloseAllFormsAsync();
            }
        }

        public static void RecordUserActivity()
        {
            ResetInactivityTimer();
        }

        private static async void OnOverdueBooksCheck(object sender, ElapsedEventArgs e)
        {
            if (IsSessionActive())
            {
                try
                {
                    await userManager.ReturnOverdueBooksAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking for overdue books: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static async Task CloseAllFormsAsync()
        {
            try
            {
                List<Form> openForms = new List<Form>();

                foreach (Form form in Application.OpenForms)
                {
                    openForms.Add(form);
                }

                foreach (Form form in openForms)
                {
                    if (form.InvokeRequired)
                    {
                        await Task.Run(() => form.Invoke(new Action(() => form.Close())));
                    }
                    else
                    {
                        form.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing forms: {ex.Message}");
            }
        }

        public static void AttachUserActivityHandlers(Form form)
        {
            form.Click += UserActivityDetected;
            form.KeyPress += UserActivityDetected;
            form.MouseMove += UserActivityDetected;
            form.KeyDown += UserActivityDetected;

            AttachHandlersToControls(form.Controls);
        }

        private static void AttachHandlersToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.Click += UserActivityDetected;
                control.KeyPress += UserActivityDetected;
                control.MouseMove += UserActivityDetected;
                control.KeyDown += UserActivityDetected;
                control.MouseHover += UserActivityDetected;

                // Recursively attach to child controls if needed
                if (control.Controls.Count > 0)
                {
                    AttachHandlersToControls(control.Controls);
                }
            }
        }

        private static void UserActivityDetected(object sender, EventArgs e)
        {
            RecordUserActivity();
        }
    }
}

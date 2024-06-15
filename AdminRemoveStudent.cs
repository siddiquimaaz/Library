using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminRemoveStudent : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";
        private readonly string logFilePath = "student_termination_log.txt";

        public AdminRemoveStudent()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdminRemoveStudent_Load);
            TerminateMemberSearchbtn.Click += new EventHandler(TerminateMemberSearchbtn_Click);
            TerminateBtn.Click += new EventHandler(TerminateBtn_Click);
        }

        private async Task LoadStudentsAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT StudentID, FirstName, LastName, Email, PhoneNumber, MembershipExpiration FROM Students";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(dt));
                            TerminateMembershipAdminPanel.DataSource = dt;

                            if (!TerminateMembershipAdminPanel.Columns.Contains("Select"))
                            {
                                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
                                {
                                    Name = "Select",
                                    HeaderText = "Select"
                                };
                                TerminateMembershipAdminPanel.Columns.Insert(0, checkboxColumn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load students: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TerminateMemberSearchbtn_Click(object sender, EventArgs e)
        {
            string readerID = ReaderID.Text.Trim();
            if (string.IsNullOrEmpty(readerID))
            {
                MessageBox.Show("Please enter a Reader ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            await SearchStudentAsync(readerID);
        }

        private async Task SearchStudentAsync(string readerID)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    string sql = "SELECT StudentID, FirstName, LastName, Email, PhoneNumber, MembershipExpiration FROM Students WHERE StudentID = @StudentID";
                    using (var cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", readerID);
                        DataTable dt = new DataTable();
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            await Task.Run(() => adapter.Fill(dt));
                            TerminateMembershipAdminPanel.DataSource = dt;

                            if (!TerminateMembershipAdminPanel.Columns.Contains("Select"))
                            {
                                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
                                {
                                    Name = "Select",
                                    HeaderText = "Select"
                                };
                                TerminateMembershipAdminPanel.Columns.Insert(0, checkboxColumn);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to search for student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TerminateBtn_Click(object? sender, EventArgs? e)
        {
            var selectedStudentIDs = TerminateMembershipAdminPanel.Rows
               .Cast<DataGridViewRow>()
               .Where(row => Convert.ToBoolean(row.Cells["Select"].Value))
               .Select(row => Convert.ToInt32(row.Cells["StudentID"].Value))
               .ToList();

            if (selectedStudentIDs.Count == 0)
            {
                MessageBox.Show("Please select at least one student to terminate.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to terminate the selected student's membership(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await TerminateStudentsAsync(selectedStudentIDs);
            }
        }

        private async Task TerminateStudentsAsync(List<int> studentIDs)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    MessageBox.Show("Database connection opened successfully.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (var studentID in studentIDs)
                    {
                        // Check for related records in borrowedbooks table
                        string checkSql = "SELECT COUNT(*) FROM borrowedbooks WHERE StudentID = @StudentID AND ReturnDate IS NULL";
                        using (var checkCmd = new MySqlCommand(checkSql, connection))
                        {
                            checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                            int count = Convert.ToInt32(await checkCmd.ExecuteScalarAsync());
                            MessageBox.Show($"Checked borrowedbooks for student ID: {studentID}. Count: {count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (count > 0)
                            {
                                // Update ReturnDate for borrowed books
                                string updateSql = "UPDATE borrowedbooks SET ReturnDate = NOW() WHERE StudentID = @StudentID AND ReturnDate IS NULL";
                                using (var updateCmd = new MySqlCommand(updateSql, connection))
                                {
                                    updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                                    await updateCmd.ExecuteNonQueryAsync();
                                    MessageBox.Show($"Updated return date for borrowed books of student ID: {studentID}.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                        // Delete the student record
                        string deleteSql = "DELETE FROM Students WHERE StudentID = @StudentID";
                        using (var deleteCmd = new MySqlCommand(deleteSql, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@StudentID", studentID);
                            await deleteCmd.ExecuteNonQueryAsync();
                            MessageBox.Show($"Deleted student ID: {studentID}.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    MessageBox.Show("Selected student memberships terminated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadStudentsAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to terminate student memberships: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LogStudentTermination(int studentID)
        {
            string logMessage = $"StudentID: {studentID}, Termination Time: {DateTime.Now}";
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
        }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void TerminateMembershipAdminPanel_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void TerminateMemberBackBtn_Click(object sender, EventArgs e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new adminpanel());
        }

        private async void AdminRemoveStudent_Load(object sender, EventArgs e)
        {

            await LoadStudentsAsync();
        }

        private void AdminRemoveReaderBackBtn_Click(object sender, EventArgs e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new adminpanel());
        }

        private void AdminRemoveStudentCloseLabel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}

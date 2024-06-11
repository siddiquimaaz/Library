using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AdminRemoveStudent : Form
    {
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public AdminRemoveStudent()
        {
            InitializeComponent();
            this.Load += new EventHandler(AdminRemoveStudentForm_Load);
            TerminateMemberSearchbtn.Click += new EventHandler(TerminateMemberSearchbtn_Click);
            TerminateBtn.Click += new EventHandler(TerminateBtn_Click);
        }

        private async void AdminRemoveStudentForm_Load(object sender, EventArgs e)
        {
            await LoadStudentsAsync();
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
                    foreach (var studentID in studentIDs)
                    {
                        string sql = "DELETE FROM Students WHERE StudentID = @StudentID";
                        using (var cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@StudentID", studentID);
                            await cmd.ExecuteNonQueryAsync();
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

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void TerminateMembershipAdminPanel_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}

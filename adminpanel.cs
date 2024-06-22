using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class adminpanel : Form
    {
        //string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";
        string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public adminpanel()
        {
            FormManager.AttachUserActivityHandlers(this);
            InitializeComponent();
            SetupDataGridView();
            this.Load += adminpanel_Load;

        }

        private void iconButton3_Click(object? sender, EventArgs? e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new BookManagerAdmin());
        }

        private async void adminpanel_Load(object sender, EventArgs e)
        {
            FormManager.AttachUserActivityHandlers(this);
            await LoadAllStudentsAsync();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                FormManager.RecordUserActivity();
                FormManager.CloseCurrentForm();
                FormManager.Show(new Form1());
            }
        }

        private async Task LoadAllStudentsAsync()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    var query = "SELECT StudentID, FirstName, LastName, Email, PhoneNumber, MembershipExpiration FROM Students";
                    using (var command = new MySqlCommand(query, connection))
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Debug: Output row count and sample data
                        Console.WriteLine($"Rows retrieved: {dataTable.Rows.Count}");
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Console.WriteLine($"{row["StudentID"]}, {row["FirstName"]}, {row["LastName"]}, {row["Email"]}, {row["PhoneNumber"]}, {row["MembershipExpiration"]}");
                        }

                        if (dataTable.Rows.Count > 0)
                        {
                            adminDataGridView.DataSource = dataTable;
                            adminDataGridView.Refresh();
                            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No students found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error loading students: {ex.Message}");
            }
        }


        private void showAllStdBtn_Click(object sender, EventArgs e) { }

        private void ShowBorrrwedBookAdmin_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new AdminBorrowedBook());
        }

        private void RemoveStdBtn_Click(object sender, EventArgs e)
        {
            FormManager.RecordUserActivity();
            FormManager.CloseCurrentForm();
            FormManager.Show(new AdminRemoveStudent());
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void adminpic_Click(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void iconButton4_(object sender, EventArgs e) { }

        private void SetupDataGridView()
        {
            try
            {
                adminDataGridView.AutoGenerateColumns = false;
                adminDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                adminDataGridView.ReadOnly = true;

                AddColumnIfMissing("StudentID", "Student ID", "StudentID");
                AddColumnIfMissing("FirstName", "First Name", "FirstName");
                AddColumnIfMissing("LastName", "Last Name", "LastName");
                AddColumnIfMissing("Email", "Email", "Email");
                AddColumnIfMissing("PhoneNumber", "Phone Number", "PhoneNumber");
                AddColumnIfMissing("MembershipExpiration", "Membership Expiration", "MembershipExpiration");

                adminDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddColumnIfMissing(string columnName, string headerText, string dataPropertyName)
        {
            if (!adminDataGridView.Columns.Contains(columnName))
            {
                var column = new DataGridViewTextBoxColumn
                {
                    Name = columnName,
                    HeaderText = headerText,
                    DataPropertyName = dataPropertyName // Bind this column to the corresponding property
                };
                adminDataGridView.Columns.Add(column);
            }
        }


        private void CloseAdminPanel_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }

        private void adminDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

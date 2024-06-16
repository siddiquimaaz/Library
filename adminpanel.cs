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

namespace Library
{
    public partial class adminpanel : Form
    {
        string connectionString = "Server=sql5.freesqldatabase.com;Database=sql5714226;Uid=sql5714226;Pwd=IgWUKSnxY1;Port=3306;";

        //string connectionString = "server=127.0.0.1;port=3306;database=LMS;user=root;password=maazsiddiqui12;";

        public adminpanel()
        {
            InitializeComponent();
            SetupDataGridView(); // Call SetupDataGridView in the constructor
            this.Load += adminpanel_Load;
        }


        private void iconButton3_Click(object? sender, EventArgs? e)
        {
            FormManager.CloseCurrentForm();
            FormManager.Show(new BookManagerAdmin());

        }

        private async void adminpanel_Load(object sender, EventArgs e)
        {
            await LoadAllStudentsAsync();
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
                        if (dataTable.Rows.Count > 0)
                        {
                            adminDataGridView.DataSource = dataTable;
                            adminDataGridView.Refresh(); // Refresh the DataGridView
                            MessageBox.Show("Data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Console.WriteLine("Data loaded successfully."); // Log success message
                        }
                        else
                        {
                            MessageBox.Show("No students found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Console.WriteLine("No data found."); // Log no data message
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error loading students: {ex.Message}"); // Log error message
            }
        }





        private void showAllStdBtn_Click(object sender, EventArgs e) { }

        private void ShowBorrrwedBookAdmin_Click(object sender, EventArgs e)
        {
            FormManager.Show(new AdminBorrowedBook());
        }

        private void RemoveStdBtn_Click(object sender, EventArgs e)
        {
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
                adminDataGridView.ReadOnly = true; // Set all cells to read-only

                // Add columns if missing
                AddColumnIfMissing("StudentID", "Student ID");
                AddColumnIfMissing("FirstName", "First Name");
                AddColumnIfMissing("LastName", "Last Name");
                AddColumnIfMissing("Email", "Email");
                AddColumnIfMissing("PhoneNumber", "Phone Number");

                // Additional columns can be added here if needed

                adminDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting up DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddColumnIfMissing(string columnName, string headerText)
        {
            if (!adminDataGridView.Columns.Contains(columnName))
            {
                adminDataGridView.Columns.Add(columnName, headerText);
            }
        }

        private void CloseAdminPanel_Click(object sender, EventArgs e)
        {
            FormManager.ClearSession();
            Application.Exit();
        }
    }
}

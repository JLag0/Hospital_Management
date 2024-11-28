using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management
{
    public partial class Nurses : Form
    {
        public Nurses()
        {
            InitializeComponent();
        }

        private void insertNurBtn_Click(object sender, EventArgs e)
        {
            // Collect input from the textboxes
            string nurseName = nurseNameTb.Text;
            string phone = nurPhoneTb.Text;
            string department = nurDepartmentTb.Text;



            string query = "INSERT INTO nurses (nursesName, phone, department) " +
                           "VALUES (@nursesName, @phone, @department)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@nursesName", nurseName);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@department", department);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert
            string customQuery = "SELECT nursesId AS [Nurse ID], nursesName AS [Nurse Name], phone AS [Phone], department AS [Department] FROM nurses";
            DataGridRefresher.RefreshDataGrid(nurGridView, customQuery);

            MessageBox.Show("Record Inserted Successfully");

        }

        private void updateNurBtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            int nursesId = int.Parse(nurseIdTb.Text); // Assuming this textbox always has the doctor's ID to update
            string nursesName = nurseNameTb.Text;
            string phone = nurPhoneTb.Text;
            string department = nurDepartmentTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(nursesName))
            {
                updates.Add("nursesName = @nursesName");
            }
            if (!string.IsNullOrEmpty(phone))
            {
                updates.Add("phone = @phone");
            }
            if (!string.IsNullOrEmpty(department))
            {
                updates.Add("department = @department");
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }

            // Join the updates for the SQL query
            string updateQuery = $"UPDATE nurses SET {string.Join(", ", updates)} WHERE nursesId = @nursesId";

            // Execute the update query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Add parameters for non-empty textboxes
                    if (!string.IsNullOrEmpty(nursesName))
                        cmd.Parameters.AddWithValue("@nursesName", nursesName);
                    if (!string.IsNullOrEmpty(phone))
                        cmd.Parameters.AddWithValue("@phone", phone);
                    if (!string.IsNullOrEmpty(department))
                        cmd.Parameters.AddWithValue("@department", department);

                    // Add the doctorId parameter
                    cmd.Parameters.AddWithValue("@nursesId", nursesId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            string customQuery = "SELECT nursesId AS [Nurse ID], nursesName AS [Nurse Name], phone AS [Phone], department AS [Department] FROM nurses";
            DataGridRefresher.RefreshDataGrid(nurGridView, customQuery);

            MessageBox.Show("Record updated successfully!");
        }

        private void deleteNurBtn_Click(object sender, EventArgs e)
        {
            // Initialize NursesID as 0 or a default value
            int nursesId;

            // Check if the input value is a valid integer
            if (int.TryParse(nurseIdTb.Text, out nursesId))
            {
                // Proceed if the NursesID is valid
                string checkQuery = "SELECT COUNT(*) FROM nurses WHERE nursesId = @nursesId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nursesId", nurseIdTb);

                        // Execute scalar to count if the nurses ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM nurses WHERE nursesId = @nursesId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@nursesId", nurseIdTb);
                                deleteCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully");

                            // Refresh the DataGridView after delete
                            string customQuery = "SELECT nursesId AS [Nurse ID], nursesName AS [Nurse Name], phone AS [Phone], department AS [Department] FROM nurses";
                            DataGridRefresher.RefreshDataGrid(nurGridView, customQuery);
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Nurse ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Nurse ID. Please enter a valid number.");
            }
        }

        private void Nurses_Load(object sender, EventArgs e)
        {
            string customQuery = "SELECT nursesId AS [Nurse ID], nursesName AS [Nurse Name], phone AS [Phone], department AS [Department] FROM nurses";
            DataGridRefresher.RefreshDataGrid(nurGridView, customQuery);

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(customQuery, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        nurGridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}

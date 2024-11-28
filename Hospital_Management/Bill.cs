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
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }

        private void insertDocBtn_Click(object sender, EventArgs e)
        {
            // Collect input from the textboxes
            string patientName = patNameTb.Text;
            string amount = amountTb.Text;
            string billStatus = statusTb.Text;
            



            string query = "INSERT INTO bill (patientName, amount, billStatus) " +
                           "VALUES (@patientName, @amount, @billStatus)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@patientName", patientName);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@billStatus", billStatus);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert
            
            string customQuery = "SELECT billId AS [Bill ID], patientName AS [Patient Name], amount AS [Amount], billStatus AS [Bill Status] FROM bill";
            DataGridRefresher.RefreshDataGrid(billGridView, customQuery);

            MessageBox.Show("Record Inserted Successfully");

        }

        private void updateDocBtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            int billId = int.Parse(billIdTb.Text); // Assuming this textbox always has the doctor's ID to update
            string patientName = patNameTb.Text;
            string amount = amountTb.Text;
            string billStatus = statusTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(patientName))
            {
                updates.Add("patientName = @patientName");
            }
            if (!string.IsNullOrEmpty(amount))
            {
                updates.Add("amount = @amount");
            }
            if (!string.IsNullOrEmpty(billStatus))
            {
                updates.Add("billStatus = @billStatus");
            }
            

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }

            // Join the updates for the SQL query
            string updateQuery = $"UPDATE bill SET {string.Join(", ", updates)} WHERE billId = @billId";

            // Execute the update query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Add parameters for non-empty textboxes
                    if (!string.IsNullOrEmpty(patientName))
                        cmd.Parameters.AddWithValue("@patientName", patientName);
                    if (!string.IsNullOrEmpty(amount))
                        cmd.Parameters.AddWithValue("@amount", amount);
                    if (!string.IsNullOrEmpty(billStatus))
                        cmd.Parameters.AddWithValue("@billStatus", billStatus);
                    

                    // Add the doctorId parameter
                    cmd.Parameters.AddWithValue("@billId", billId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            string customQuery = "SELECT billId AS [Bill ID], patientName AS [Patient Name], amount AS [Amount], billStatus AS [Bill Status] FROM bill";
            DataGridRefresher.RefreshDataGrid(billGridView, customQuery);

            MessageBox.Show("Record updated successfully!");
        }


        private void deleteDocBtn_Click(object sender, EventArgs e)
        {
            // Initialize DoctorsID as 0 or a default value
            int billId;

            // Check if the input value is a valid integer
            if (int.TryParse(billIdTb.Text, out billId))
            {
                // Proceed if the DoctorsID is valid
                string checkQuery = "SELECT COUNT(*) FROM bill WHERE billId = @billId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@billId", billId);

                        // Execute scalar to count if the patient ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM bill WHERE billId = @billId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@billId", billId);
                                deleteCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully");

                            // Refresh the DataGridView after delete
                            string customQuery = "SELECT billId AS [Bill ID], patientName AS [Patient Name], amount AS [Amount], billStatus AS [Bill Status] FROM bill";
                            DataGridRefresher.RefreshDataGrid(billGridView, customQuery);
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Bill ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Bill ID. Please enter a valid number.");
            }
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            string customQuery = "SELECT billId AS [Bill ID], patientName AS [Patient Name], amount AS [Amount], billStatus AS [Bill Status] FROM bill";
            DataGridRefresher.RefreshDataGrid(billGridView, customQuery);

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
                        billGridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}

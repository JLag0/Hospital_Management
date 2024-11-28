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
using Microsoft.IdentityModel.Tokens;
using System.Net.NetworkInformation;

namespace Hospital_Management
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void insertDocBtn_Click(object sender, EventArgs e)
        {
            // Collect input from the textboxes
            string docName = doctorNameTb.Text;
            string docSpeciality = specialityTb.Text;
            int docPhone = int.Parse(docPhoneTb.Text);
            string docDepartment = departmentTb.Text;
           


            string query = "INSERT INTO doctors (docName, docSpeciality, docPhone, docDepartment) " +
                           "VALUES (@docName, @docSpeciality, @docPhone, @docDepartment)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@docName", docName);
                    cmd.Parameters.AddWithValue("@docPhone", docPhone);
                    cmd.Parameters.AddWithValue("@docSpeciality", docSpeciality);
                    cmd.Parameters.AddWithValue("@docDepartment", docDepartment);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert

            string customQuery = "SELECT doctorId AS [Doctor ID], docName AS [Doctor Name], docPhone AS [Phone], docSpeciality AS [Speciality], docDepartment AS [Department] FROM doctors";
            DataGridRefresher.RefreshDataGrid(docGridView, customQuery);
            MessageBox.Show("Record Inserted Successfully");

        }

        private void updateDocBtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            int doctorId = int.Parse(doctorIdTb.Text); // Assuming this textbox always has the doctor's ID to update
            string docName = doctorNameTb.Text;
            string docSpeciality = specialityTb.Text;
            string docPhone = docPhoneTb.Text;
            string docDepartment = departmentTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(docName))
            {
                updates.Add("docName = @docName");
            }
            if (!string.IsNullOrEmpty(docSpeciality))
            {
                updates.Add("docSpeciality = @docSpeciality");
            }
            if (!string.IsNullOrEmpty(docPhone))
            {
                updates.Add("docPhone = @docPhone");
            }
            if (!string.IsNullOrEmpty(docDepartment))
            {
                updates.Add("docDepartment = @docDepartment");
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }

            // Join the updates for the SQL query
            string updateQuery = $"UPDATE doctors SET {string.Join(", ", updates)} WHERE doctorId = @doctorId";

            // Execute the update query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Add parameters for non-empty textboxes
                    if (!string.IsNullOrEmpty(docName))
                        cmd.Parameters.AddWithValue("@docName", docName);
                    if (!string.IsNullOrEmpty(docSpeciality))
                        cmd.Parameters.AddWithValue("@docSpeciality", docSpeciality);
                    if (!string.IsNullOrEmpty(docPhone))
                        cmd.Parameters.AddWithValue("@docPhone", docPhone);
                    if (!string.IsNullOrEmpty(docDepartment))
                        cmd.Parameters.AddWithValue("@docDepartment", docDepartment);

                    // Add the doctorId parameter
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            string customQuery = "SELECT doctorId AS [Doctor ID], docName AS [Doctor Name], docPhone AS [Phone], docSpeciality AS [Speciality], docDepartment AS [Department] FROM doctors";
            DataGridRefresher.RefreshDataGrid(docGridView, customQuery);

            MessageBox.Show("Record updated successfully!");
        }


        private void deleteDocBtn_Click(object sender, EventArgs e)
        {
            // Initialize DoctorsID as 0 or a default value
            int doctorId;

            // Check if the input value is a valid integer
            if (int.TryParse(doctorIdTb.Text, out doctorId))
            {
                // Proceed if the DoctorsID is valid
                string checkQuery = "SELECT COUNT(*) FROM doctors WHERE doctorId = @doctorId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@doctorId", doctorIdTb);

                        // Execute scalar to count if the patient ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM doctors WHERE doctorId = @doctorId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@doctorId", doctorId);
                                deleteCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully");

                            // Refresh the DataGridView after delete
                            string customQuery = "SELECT doctorId AS [Doctor ID], docName AS [Doctor Name], docPhone AS [Phone], docSpeciality AS [Speciality], docDepartment AS [Department] FROM doctors";
                            DataGridRefresher.RefreshDataGrid(docGridView, customQuery);
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Doctor ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Doctors ID. Please enter a valid number.");
            }
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            string customQuery = "SELECT doctorId AS [Doctor ID], docName AS [Doctor Name], docPhone AS [Phone], docSpeciality AS [Speciality], docDepartment AS [Department] FROM doctors";
            DataGridRefresher.RefreshDataGrid(docGridView, customQuery);

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
                        docGridView.DataSource = dataTable;
                    }
                }
            }
        }

        
    }
}

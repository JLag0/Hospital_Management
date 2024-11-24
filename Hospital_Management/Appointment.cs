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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void insertDocBtn_Click(object sender, EventArgs e)
        {
            // Collect input from the textboxes
            string patientName = appPatNameTb.Text;
            string doctorName = appDocNameTb.Text;
            string dateCreated = appDatePckr.Text;
            string appstatus = statusTb.Text;



            string query = "INSERT INTO appointment (patientName, doctorName, dateCreated, appstatus) " +
                           "VALUES (@patientName, @doctorName, @dateCreated, @appstatus)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@patientName", patientName);
                    cmd.Parameters.AddWithValue("@doctorName", doctorName);
                    cmd.Parameters.AddWithValue("@dateCreated", dateCreated);
                    cmd.Parameters.AddWithValue("@appstatus", appstatus);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert
            DataGridRefresher.RefreshDataGrid(appGridView, "appointment");

            MessageBox.Show("Record Inserted Successfully");

        }

        private void updateDocBtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            int appointmentId = int.Parse(appIdTb.Text); // Assuming this textbox always has the doctor's ID to update
            string patientName = appPatNameTb.Text;
            string doctorName = appDocNameTb.Text;
            string dateCreated = appDatePckr.Text;
            string appstatus = statusTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(patientName))
            {
                updates.Add("patientName = @patientName");
            }
            if (!string.IsNullOrEmpty(doctorName))
            {
                updates.Add("doctorName = @doctorName");
            }
            if (!string.IsNullOrEmpty(dateCreated))
            {
                updates.Add("dateCreated = @dateCreated");
            }
            if (!string.IsNullOrEmpty(appstatus))
            {
                updates.Add("appstatus = @appstatus");
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }

            // Join the updates for the SQL query
            string updateQuery = $"UPDATE appointment SET {string.Join(", ", updates)} WHERE appointmentId = @appointmentId";

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
                    if (!string.IsNullOrEmpty(doctorName))
                        cmd.Parameters.AddWithValue("@doctorName", doctorName);
                    if (!string.IsNullOrEmpty(dateCreated))
                        cmd.Parameters.AddWithValue("@dateCreated", dateCreated);
                    if (!string.IsNullOrEmpty(appstatus))
                        cmd.Parameters.AddWithValue("@appstatus", appstatus);

                    // Add the AppointmentID parameter
                    cmd.Parameters.AddWithValue("@appointmentId", appointmentId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            DataGridRefresher.RefreshDataGrid(appGridView, "appointment");

            MessageBox.Show("Record updated successfully!");
        }

        private void deleteDocBtn_Click(object sender, EventArgs e)
        {
            // Initialize AppointmentID as 0 or a default value
            int appointmentId;

            // Check if the input value is a valid integer
            if (int.TryParse(appIdTb.Text, out appointmentId))
            {
                // Proceed if the AppointmentID is valid
                string checkQuery = "SELECT COUNT(*) FROM appointment WHERE appointmentId = @appointmentId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@appointmentId", appIdTb);

                        // Execute scalar to count if the appointment ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@appointmentId", appIdTb);
                                deleteCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully");

                            // Refresh the DataGridView after delete
                            DataGridRefresher.RefreshDataGrid(appGridView, "appointment");
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Appointment ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Appointment ID. Please enter a valid number.");
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM appointment";

            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        appGridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}

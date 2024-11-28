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
using System.Net.NetworkInformation;

namespace Hospital_Management
{
    public partial class MedicalRecord : Form
    {
        public MedicalRecord()
        {
            InitializeComponent();
        }
        private void insertMRBtn_Click(object sender, EventArgs e)
        {
            // Collect input from the textboxes
            string medRecPatientName = mrPatNameTb.Text;
            string medRecDoctorName = mrDocNameTb.Text;
            string medRecNurName = mrNurTb.Text;
            string medRecDiagnosis = mrDiagTb.Text;
            string medRecPres = mrPresTb.Text;
            string medRecTreatment = mrTreatTb.Text; 

            string query = "INSERT INTO medicalRecord (medRecPatientName, medRecDoctorName, medRecNurName, medRecDiagnosis, medRecPres, medRecTreatment) " +
                           "VALUES (@medRecPatientName, @medRecDoctorName, @medRecNurName, @medRecDiagnosis, @medRecPres, @medRecTreatment)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@medRecPatientName", medRecPatientName);
                    cmd.Parameters.AddWithValue("@medRecDoctorName", medRecDoctorName);
                    cmd.Parameters.AddWithValue("@medRecNurName", medRecNurName);
                    cmd.Parameters.AddWithValue("@medRecDiagnosis", medRecDiagnosis);
                    cmd.Parameters.AddWithValue("@medRecPres", medRecPres);
                    cmd.Parameters.AddWithValue("@medRecTreatment", medRecTreatment);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert
            DataGridRefresher.RefreshDataGrid(medRecGridView, "medicalRecord");

            MessageBox.Show("Record Inserted Successfully");

        }

        private void updateMRBtn_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            int medicalRecId = int.Parse(medRecIdTb.Text); // Assuming this textbox always has the Medical Record's ID to update
            string medRecPatientName = mrPatNameTb.Text;
            string medRecDoctorName = mrDocNameTb.Text;
            string medRecNurName = mrNurTb.Text;
            string medRecDiagnosis = mrDiagTb.Text;
            string medRecPres = mrPresTb.Text;
            string medRecTreatment = mrTreatTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(medRecPatientName))
            {
                updates.Add("medRecPatientName = @medRecPatientName");
            }
            if (!string.IsNullOrEmpty(medRecDoctorName))
            {
                updates.Add("medRecDoctorName = @medRecDoctorName");
            }
            if (!string.IsNullOrEmpty(medRecNurName))
            {
                updates.Add("medRecNurName = @medRecNurName");
            }
            if (!string.IsNullOrEmpty(medRecDiagnosis))
            {
                updates.Add("medRecDiagnosis = @medRecDiagnosis");
            }
            if (!string.IsNullOrEmpty(medRecPres))
            {
                updates.Add("medRecPres = @medRecPres");
            }
            if (!string.IsNullOrEmpty(medRecTreatment))
            {
                updates.Add("medRecTreatment = @medRecTreatment");
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }

            // Join the updates for the SQL query
            string updateQuery = $"UPDATE medicalRecord SET {string.Join(", ", updates)} WHERE medicalRecId = @medicalRecId";

            // Execute the update query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Add parameters for non-empty textboxes
                    if (!string.IsNullOrEmpty(medRecPatientName))
                        cmd.Parameters.AddWithValue("@medRecPatientName", medRecPatientName);
                    if (!string.IsNullOrEmpty(medRecDoctorName))
                        cmd.Parameters.AddWithValue("@medRecDoctorName", medRecDoctorName);
                    if (!string.IsNullOrEmpty(medRecNurName))
                        cmd.Parameters.AddWithValue("@medRecNurName", medRecNurName);
                    if (!string.IsNullOrEmpty(medRecDiagnosis))
                        cmd.Parameters.AddWithValue("@medRecDiagnosis", medRecDiagnosis);
                    if (!string.IsNullOrEmpty(medRecPres))
                        cmd.Parameters.AddWithValue("@medRecPres", medRecPres);
                    if (!string.IsNullOrEmpty(medRecTreatment))
                        cmd.Parameters.AddWithValue("@medRecTreatment", medRecTreatment);

                    // Add the doctorId parameter
                    cmd.Parameters.AddWithValue("@medicalRecId", medicalRecId);

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            DataGridRefresher.RefreshDataGrid(medRecGridView, "medicalRecord");

            MessageBox.Show("Record updated successfully!");
        }

        private void deleteMRBtn_Click(object sender, EventArgs e)
        {
            // Initialize DoctorsID as 0 or a default value
            int medicalRecId;

            // Check if the input value is a valid integer
            if (int.TryParse(medRecIdTb.Text, out medicalRecId))
            {
                // Proceed if the DoctorsID is valid
                string checkQuery = "SELECT COUNT(*) FROM medicalRecord WHERE medicalRecId = @medicalRecId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@medicalRecId", medicalRecId);

                        // Execute scalar to count if the Medical Record ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM medicalRecord WHERE medicalRecId = @medicalRecId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@medicalRecId", medicalRecId);
                                deleteCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Record Deleted Successfully");

                            // Refresh the DataGridView after delete
                            DataGridRefresher.RefreshDataGrid(medRecGridView, "medicalRecord");
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Medical Record ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Medical Record ID. Please enter a valid number.");
            }
        }
        private void MedicalRecord_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM medicalRecord";

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
                        medRecGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void mrRetButton_Click(object sender, EventArgs e)
        {
            return;
        }

        
    }
}

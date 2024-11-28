using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;  
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace Hospital_Management
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }


        // if the insert button is clicked this will exec
        private void InsertBtn_Click(object sender, EventArgs e)
        {


            // Collect input from the textboxes
            string patientsName = patientNametb.Text;
            int age = int.Parse(ageTb.Text);
            string gender = genderTb.Text;
            string adress = adressTb.Text;

            
            string query = "INSERT INTO patients (patientsName, age, gender, adress) " +
                           "VALUES (@patientsName, @age, @gender, @adress)";

            // Set up the database connection and execute the query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters for the other columns
                    cmd.Parameters.AddWithValue("@patientsName", patientsName);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@adress", adress);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after insert
            string customQuery = "SELECT patientsId AS [Patient ID], patientsName AS [Patient Name], age AS [Age], gender AS [Gender], adress AS [Address] FROM patients";
            DataGridRefresher.RefreshDataGrid(patGridView, customQuery);


            MessageBox.Show("Record Inserted Successfully");

        }

        // if update button is clicked this will exec
        private void updateBtn_Click(object sender, EventArgs e)
            {
            // Get the patient ID and other inputs from textboxes
            int patientID;
            if (!int.TryParse(patientIDtb.Text, out patientID))
            {
                MessageBox.Show("Invalid Patient ID.");
                return;
            }

            string patientsName = patientNametb.Text;
            string age = ageTb.Text;
            string gender = genderTb.Text;
            string adress = adressTb.Text;

            // Build the dynamic query based on which fields are filled
            List<string> updates = new List<string>();
            if (!string.IsNullOrEmpty(patientsName))
            {
                updates.Add("patientsName = @patientsName");
            }
            if (!string.IsNullOrEmpty(age))
            {
                updates.Add("age = @age");
            }
            if (!string.IsNullOrEmpty(gender))
            {
                updates.Add("gender = @gender");
            }
            if (!string.IsNullOrEmpty(adress))
            {
                updates.Add("adress = @adress");
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No updates to apply.");
                return;
            }
            // Join the updates for the SQL query
            string updateQuery = $"UPDATE patients SET {string.Join(", ", updates)} WHERE patientsId=@patientsId";
            
            

            // Execute the update query
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    // Add parameters for non-empty textboxes
                    if (!string.IsNullOrEmpty(patientsName))
                        cmd.Parameters.AddWithValue("@patientsName", patientsName);
                    if (!string.IsNullOrEmpty(age))
                        cmd.Parameters.AddWithValue("@age", age);
                    if (!string.IsNullOrEmpty(gender))
                        cmd.Parameters.AddWithValue("@gender", gender);
                    if (!string.IsNullOrEmpty(adress))
                        cmd.Parameters.AddWithValue("@adress", adress);

                    // Add the doctorId parameter
                    cmd.Parameters.AddWithValue("@patientsId", patientID);


                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
            // Refresh the DataGridView after update
            string customQuery = "SELECT patientsId AS [Patient ID], patientsName AS [Patient Name], age AS [Age], gender AS [Gender], adress AS [Address] FROM patients";
            DataGridRefresher.RefreshDataGrid(patGridView, customQuery);

            MessageBox.Show("Record updated successfully!");
        }

        //if delete button is clicked this will exec
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Initialize patientID as 0 or a default value
            int patientID;

            // Check if the input value is a valid integer
            if (int.TryParse(patientIDtb.Text, out patientID))
            {
                // Proceed if the patientID is valid
                string checkQuery = "SELECT COUNT(*) FROM patients WHERE patientsId = @patientsId";

                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@patientsId", patientID);

                        // Execute scalar to count if the patient ID exists
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the record exists, proceed with deletion
                        if (count > 0)
                        {
                            string deleteQuery = "DELETE FROM patients WHERE patientsId = @patientsId";

                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@patientsId", patientID);
                                deleteCmd.ExecuteNonQuery();
                            }
                            // Refresh the DataGridView after update
                            string customQuery = "SELECT patientsId AS [Patient ID], patientsName AS [Patient Name], age AS [Age], gender AS [Gender], adress AS [Address] FROM patients";
                            DataGridRefresher.RefreshDataGrid(patGridView, customQuery);

                            MessageBox.Show("Record Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with this Patient ID.");
                        }
                    }
                }
            }
            else
            {
                // If input is invalid, show a message to the user
                MessageBox.Show("Invalid Patient ID. Please enter a valid number.");
            }
        }




        // if the Patients Form loads this will exec
        private void Patients_Load(object sender, EventArgs e)
        {
            string customQuery = "SELECT patientsId AS [Patient ID], patientsName AS [Patient Name], age AS [Age], gender AS [Gender], adress AS [Address] FROM patients";
            DataGridRefresher.RefreshDataGrid(patGridView, customQuery);

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
                        patGridView.DataSource = dataTable; 
                    }
                }
            }
        }

       
    }
}

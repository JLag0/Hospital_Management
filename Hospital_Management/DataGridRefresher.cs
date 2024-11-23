using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public static class DataGridRefresher
    {
        public static void RefreshDataGrid(DataGridView dataGridView, string tableName)
        {
            string query = $"SELECT * FROM {tableName}"; // Use the table name (patients or doctors)

            // Create a connection object
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt); // Fill the DataTable with the data from the database

                // Bind the DataTable to the DataGridView
                dataGridView.DataSource = dt;
            }
        }
    }
}

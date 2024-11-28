using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hospital_Management
{
    public static class DataGridRefresher
    {
        
        public static void RefreshDataGrid(DataGridView dataGridView, string query)
        {
            try
            {
                // Create a connection object
                DatabaseConnection dbConnection = new DatabaseConnection();
                using (SqlConnection conn = dbConnection.GetConnection())
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt); // fills the datatable

                    
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                //show message box
                MessageBox.Show($"Error refreshing data grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public static void RefreshDataGridByTable(DataGridView dataGridView, string tableName)
        {
            string query = $"SELECT * FROM {tableName}";
            RefreshDataGrid(dataGridView, query);
        }
    }
}

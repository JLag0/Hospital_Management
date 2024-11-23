using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Management
{
    internal class DatabaseConnection
    {
        private SqlConnection connection;

        public DatabaseConnection()
        {
            
            string conString = "Data Source=ULYSIS;Initial Catalog=CareCentralHospitalDB;Integrated Security=True;Encrypt=False";
            connection = new SqlConnection(conString); 
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public SqlCommand GetCommand(string query)
        {
            
            SqlCommand command = new SqlCommand(query, connection);
            return command;
        }

    }
}

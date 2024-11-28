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
using System.Data.Common;
using System.Collections;

namespace Hospital_Management
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayTotalPatients();
            DisplayTotalDoctors();
            DisplayTotalNurses();
            DisplayAppointment();
        }

        private void DisplayTotalPatients()
        {
            string conString = "Data Source=ULYSIS;Initial Catalog=CareCentralHospitalDB;Integrated Security=True;Encrypt=False";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM patients";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))

                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        totalPat.Text = count.ToString(); 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayTotalDoctors()
        {
            string conString = "Data Source=ULYSIS;Initial Catalog=CareCentralHospitalDB;Integrated Security=True;Encrypt=False";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM doctors";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))

                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        totalDoc.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayTotalNurses()
        {
            string conString = "Data Source=ULYSIS;Initial Catalog=CareCentralHospitalDB;Integrated Security=True;Encrypt=False";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM nurses";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))

                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        totalNur.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayAppointment()
        {
            string conString = "Data Source=ULYSIS;Initial Catalog=CareCentralHospitalDB;Integrated Security=True;Encrypt=False";
            DatabaseConnection dbConnection = new DatabaseConnection();
            using (SqlConnection conn = dbConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM appointment";
                    using (SqlCommand cmd = new SqlCommand(checkQuery, conn))

                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        appointment.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}

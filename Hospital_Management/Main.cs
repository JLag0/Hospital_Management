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
using Hospital_Management;

namespace Hospital_Management
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        private void patientBtn_Click(object sender, EventArgs e)
        {
            Patients patientsForm = new Patients();

            // Show the Patients form
            patientsForm.Show();

            
        }

        private void doctorBtn_Click(object sender, EventArgs e)
        {
            // Show the Doctors form
            Doctors doctorsForm = new Doctors();
            doctorsForm.Show();
        }
    }
}

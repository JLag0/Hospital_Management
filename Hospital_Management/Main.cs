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

        private void nurseBtn_Click(object sender, EventArgs e)
        {
            // Show the Nurses form
            Nurses NursesForm = new Nurses();
            NursesForm.Show();
        }

        private void appointmentBtn_Click(object sender, EventArgs e)
        {
            // Show the Appointment form
            AppointmentForm AppointmentForm = new AppointmentForm();
            AppointmentForm.Show();
        }

        private void medicalRecordBtn_Click(object sender, EventArgs e)
        {
            // Show the Medical Record form
            MedicalRecord MedicalRecordForm = new MedicalRecord();
            MedicalRecordForm.Show();
        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            // Show the Bill form
            BillForm BillForm = new BillForm();
            BillForm.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            // Show the Dashboard form
            Dashboard DashboardForm = new Dashboard();
            DashboardForm.Show();
        }
    }
}

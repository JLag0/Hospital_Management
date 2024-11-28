namespace Hospital_Management
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.labelDashboard = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.patientPnl = new System.Windows.Forms.Panel();
            this.totalPat = new System.Windows.Forms.Label();
            this.totalPatLbl = new System.Windows.Forms.Label();
            this.totalDoc = new System.Windows.Forms.Label();
            this.totalDocPnl = new System.Windows.Forms.Label();
            this.doctorPnl = new System.Windows.Forms.Panel();
            this.totalNur = new System.Windows.Forms.Label();
            this.totalNurLbl = new System.Windows.Forms.Label();
            this.nursesPnl = new System.Windows.Forms.Panel();
            this.appointment = new System.Windows.Forms.Label();
            this.appLbl = new System.Windows.Forms.Label();
            this.appointmentPnl = new System.Windows.Forms.Panel();
            this.topPnl.SuspendLayout();
            this.patientPnl.SuspendLayout();
            this.doctorPnl.SuspendLayout();
            this.nursesPnl.SuspendLayout();
            this.appointmentPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.Location = new System.Drawing.Point(168, 9);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(511, 45);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Care Central Hospital Dashboard";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.topPnl.Controls.Add(this.labelDashboard);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(847, 60);
            this.topPnl.TabIndex = 3;
            // 
            // patientPnl
            // 
            this.patientPnl.BackColor = System.Drawing.Color.Lime;
            this.patientPnl.Controls.Add(this.totalPat);
            this.patientPnl.Controls.Add(this.totalPatLbl);
            this.patientPnl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientPnl.Location = new System.Drawing.Point(88, 91);
            this.patientPnl.Name = "patientPnl";
            this.patientPnl.Size = new System.Drawing.Size(240, 143);
            this.patientPnl.TabIndex = 4;
            // 
            // totalPat
            // 
            this.totalPat.AutoSize = true;
            this.totalPat.Location = new System.Drawing.Point(43, 62);
            this.totalPat.Name = "totalPat";
            this.totalPat.Size = new System.Drawing.Size(25, 30);
            this.totalPat.TabIndex = 1;
            this.totalPat.Text = "0";
            // 
            // totalPatLbl
            // 
            this.totalPatLbl.AutoSize = true;
            this.totalPatLbl.Location = new System.Drawing.Point(43, 21);
            this.totalPatLbl.Name = "totalPatLbl";
            this.totalPatLbl.Size = new System.Drawing.Size(157, 30);
            this.totalPatLbl.TabIndex = 0;
            this.totalPatLbl.Text = "Total Patients: ";
            // 
            // totalDoc
            // 
            this.totalDoc.AutoSize = true;
            this.totalDoc.Location = new System.Drawing.Point(43, 62);
            this.totalDoc.Name = "totalDoc";
            this.totalDoc.Size = new System.Drawing.Size(25, 30);
            this.totalDoc.TabIndex = 1;
            this.totalDoc.Text = "0";
            // 
            // totalDocPnl
            // 
            this.totalDocPnl.AutoSize = true;
            this.totalDocPnl.Location = new System.Drawing.Point(43, 21);
            this.totalDocPnl.Name = "totalDocPnl";
            this.totalDocPnl.Size = new System.Drawing.Size(155, 30);
            this.totalDocPnl.TabIndex = 0;
            this.totalDocPnl.Text = "Total Doctors: ";
            // 
            // doctorPnl
            // 
            this.doctorPnl.BackColor = System.Drawing.Color.Lime;
            this.doctorPnl.Controls.Add(this.totalDoc);
            this.doctorPnl.Controls.Add(this.totalDocPnl);
            this.doctorPnl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPnl.Location = new System.Drawing.Point(508, 91);
            this.doctorPnl.Name = "doctorPnl";
            this.doctorPnl.Size = new System.Drawing.Size(240, 143);
            this.doctorPnl.TabIndex = 8;
            // 
            // totalNur
            // 
            this.totalNur.AutoSize = true;
            this.totalNur.Location = new System.Drawing.Point(43, 62);
            this.totalNur.Name = "totalNur";
            this.totalNur.Size = new System.Drawing.Size(25, 30);
            this.totalNur.TabIndex = 1;
            this.totalNur.Text = "0";
            // 
            // totalNurLbl
            // 
            this.totalNurLbl.AutoSize = true;
            this.totalNurLbl.Location = new System.Drawing.Point(43, 21);
            this.totalNurLbl.Name = "totalNurLbl";
            this.totalNurLbl.Size = new System.Drawing.Size(146, 30);
            this.totalNurLbl.TabIndex = 0;
            this.totalNurLbl.Text = "Total Nurses: ";
            // 
            // nursesPnl
            // 
            this.nursesPnl.BackColor = System.Drawing.Color.Lime;
            this.nursesPnl.Controls.Add(this.totalNur);
            this.nursesPnl.Controls.Add(this.totalNurLbl);
            this.nursesPnl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nursesPnl.Location = new System.Drawing.Point(88, 274);
            this.nursesPnl.Name = "nursesPnl";
            this.nursesPnl.Size = new System.Drawing.Size(240, 143);
            this.nursesPnl.TabIndex = 9;
            // 
            // appointment
            // 
            this.appointment.AutoSize = true;
            this.appointment.Location = new System.Drawing.Point(43, 62);
            this.appointment.Name = "appointment";
            this.appointment.Size = new System.Drawing.Size(25, 30);
            this.appointment.TabIndex = 1;
            this.appointment.Text = "0";
            // 
            // appLbl
            // 
            this.appLbl.AutoSize = true;
            this.appLbl.Location = new System.Drawing.Point(43, 21);
            this.appLbl.Name = "appLbl";
            this.appLbl.Size = new System.Drawing.Size(166, 30);
            this.appLbl.TabIndex = 0;
            this.appLbl.Text = "Appointments: ";
            // 
            // appointmentPnl
            // 
            this.appointmentPnl.AccessibleDescription = "The available  appointments";
            this.appointmentPnl.BackColor = System.Drawing.Color.Lime;
            this.appointmentPnl.Controls.Add(this.appointment);
            this.appointmentPnl.Controls.Add(this.appLbl);
            this.appointmentPnl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentPnl.Location = new System.Drawing.Point(508, 274);
            this.appointmentPnl.Name = "appointmentPnl";
            this.appointmentPnl.Size = new System.Drawing.Size(240, 143);
            this.appointmentPnl.TabIndex = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.appointmentPnl);
            this.Controls.Add(this.nursesPnl);
            this.Controls.Add(this.doctorPnl);
            this.Controls.Add(this.patientPnl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.patientPnl.ResumeLayout(false);
            this.patientPnl.PerformLayout();
            this.doctorPnl.ResumeLayout(false);
            this.doctorPnl.PerformLayout();
            this.nursesPnl.ResumeLayout(false);
            this.nursesPnl.PerformLayout();
            this.appointmentPnl.ResumeLayout(false);
            this.appointmentPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Panel patientPnl;
        private System.Windows.Forms.Label totalPat;
        private System.Windows.Forms.Label totalPatLbl;
        private System.Windows.Forms.Label totalDoc;
        private System.Windows.Forms.Label totalDocPnl;
        private System.Windows.Forms.Panel doctorPnl;
        private System.Windows.Forms.Label totalNur;
        private System.Windows.Forms.Label totalNurLbl;
        private System.Windows.Forms.Panel nursesPnl;
        private System.Windows.Forms.Label appointment;
        private System.Windows.Forms.Label appLbl;
        private System.Windows.Forms.Panel appointmentPnl;
    }
}
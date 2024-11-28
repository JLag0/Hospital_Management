namespace Hospital_Management
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.topPnl = new System.Windows.Forms.Panel();
            this.HospitalManagementSystemLbl = new System.Windows.Forms.Label();
            this.leftPnl = new System.Windows.Forms.Panel();
            this.medicalRecordBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.appointmentBtn = new System.Windows.Forms.Button();
            this.nurseBtn = new System.Windows.Forms.Button();
            this.doctorBtn = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.Button();
            this.careCentralHospitalLbl = new System.Windows.Forms.Label();
            this.topPnl.SuspendLayout();
            this.leftPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.topPnl.Controls.Add(this.HospitalManagementSystemLbl);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(830, 54);
            this.topPnl.TabIndex = 0;
            // 
            // HospitalManagementSystemLbl
            // 
            this.HospitalManagementSystemLbl.AutoSize = true;
            this.HospitalManagementSystemLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HospitalManagementSystemLbl.Location = new System.Drawing.Point(11, 8);
            this.HospitalManagementSystemLbl.Name = "HospitalManagementSystemLbl";
            this.HospitalManagementSystemLbl.Size = new System.Drawing.Size(403, 37);
            this.HospitalManagementSystemLbl.TabIndex = 0;
            this.HospitalManagementSystemLbl.Text = "Hospital Management System";
            // 
            // leftPnl
            // 
            this.leftPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(175)))), ((int)(((byte)(220)))));
            this.leftPnl.Controls.Add(this.medicalRecordBtn);
            this.leftPnl.Controls.Add(this.dashboardBtn);
            this.leftPnl.Controls.Add(this.billBtn);
            this.leftPnl.Controls.Add(this.appointmentBtn);
            this.leftPnl.Controls.Add(this.nurseBtn);
            this.leftPnl.Controls.Add(this.doctorBtn);
            this.leftPnl.Controls.Add(this.patientBtn);
            this.leftPnl.Controls.Add(this.careCentralHospitalLbl);
            this.leftPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPnl.Location = new System.Drawing.Point(0, 54);
            this.leftPnl.Name = "leftPnl";
            this.leftPnl.Size = new System.Drawing.Size(200, 497);
            this.leftPnl.TabIndex = 1;
            // 
            // medicalRecordBtn
            // 
            this.medicalRecordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalRecordBtn.Location = new System.Drawing.Point(11, 291);
            this.medicalRecordBtn.Name = "medicalRecordBtn";
            this.medicalRecordBtn.Size = new System.Drawing.Size(174, 54);
            this.medicalRecordBtn.TabIndex = 7;
            this.medicalRecordBtn.Text = "Medical Record";
            this.medicalRecordBtn.UseVisualStyleBackColor = true;
            this.medicalRecordBtn.Click += new System.EventHandler(this.medicalRecordBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.Location = new System.Drawing.Point(11, 411);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(174, 54);
            this.dashboardBtn.TabIndex = 6;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBtn.Location = new System.Drawing.Point(11, 351);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(174, 54);
            this.billBtn.TabIndex = 5;
            this.billBtn.Text = "Bill";
            this.billBtn.UseVisualStyleBackColor = true;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // appointmentBtn
            // 
            this.appointmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentBtn.Location = new System.Drawing.Point(11, 231);
            this.appointmentBtn.Name = "appointmentBtn";
            this.appointmentBtn.Size = new System.Drawing.Size(174, 54);
            this.appointmentBtn.TabIndex = 4;
            this.appointmentBtn.Text = "Appointment";
            this.appointmentBtn.UseVisualStyleBackColor = true;
            this.appointmentBtn.Click += new System.EventHandler(this.appointmentBtn_Click);
            // 
            // nurseBtn
            // 
            this.nurseBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseBtn.Location = new System.Drawing.Point(11, 171);
            this.nurseBtn.Name = "nurseBtn";
            this.nurseBtn.Size = new System.Drawing.Size(174, 54);
            this.nurseBtn.TabIndex = 3;
            this.nurseBtn.Text = "Nurse";
            this.nurseBtn.UseVisualStyleBackColor = true;
            this.nurseBtn.Click += new System.EventHandler(this.nurseBtn_Click);
            // 
            // doctorBtn
            // 
            this.doctorBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorBtn.Location = new System.Drawing.Point(11, 111);
            this.doctorBtn.Name = "doctorBtn";
            this.doctorBtn.Size = new System.Drawing.Size(174, 54);
            this.doctorBtn.TabIndex = 2;
            this.doctorBtn.Text = "Doctor";
            this.doctorBtn.UseVisualStyleBackColor = true;
            this.doctorBtn.Click += new System.EventHandler(this.doctorBtn_Click);
            // 
            // patientBtn
            // 
            this.patientBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientBtn.Location = new System.Drawing.Point(11, 51);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(174, 54);
            this.patientBtn.TabIndex = 1;
            this.patientBtn.Text = "Patient";
            this.patientBtn.UseVisualStyleBackColor = true;
            this.patientBtn.Click += new System.EventHandler(this.patientBtn_Click);
            // 
            // careCentralHospitalLbl
            // 
            this.careCentralHospitalLbl.AutoSize = true;
            this.careCentralHospitalLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.careCentralHospitalLbl.Location = new System.Drawing.Point(14, 15);
            this.careCentralHospitalLbl.Name = "careCentralHospitalLbl";
            this.careCentralHospitalLbl.Size = new System.Drawing.Size(171, 21);
            this.careCentralHospitalLbl.TabIndex = 0;
            this.careCentralHospitalLbl.Text = "Care Central Hospital";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(175)))), ((int)(((byte)(220)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(830, 551);
            this.Controls.Add(this.leftPnl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.leftPnl.ResumeLayout(false);
            this.leftPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Panel leftPnl;
        private System.Windows.Forms.Label HospitalManagementSystemLbl;
        private System.Windows.Forms.Label careCentralHospitalLbl;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button appointmentBtn;
        private System.Windows.Forms.Button nurseBtn;
        private System.Windows.Forms.Button doctorBtn;
        private System.Windows.Forms.Button patientBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button medicalRecordBtn;
    }
}
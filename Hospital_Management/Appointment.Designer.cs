namespace Hospital_Management
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.labelAppointment = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.appIdTb = new System.Windows.Forms.TextBox();
            this.appoIDLbl = new System.Windows.Forms.Label();
            this.appPatNameTb = new System.Windows.Forms.TextBox();
            this.patientNameLbl = new System.Windows.Forms.Label();
            this.appDocNameTb = new System.Windows.Forms.TextBox();
            this.docNameLbl = new System.Windows.Forms.Label();
            this.dateCreatedLbl = new System.Windows.Forms.Label();
            this.statusTb = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.appDatePckr = new System.Windows.Forms.DateTimePicker();
            this.appGridView = new System.Windows.Forms.DataGridView();
            this.deleteAppBtn = new System.Windows.Forms.Button();
            this.updateAppBtn = new System.Windows.Forms.Button();
            this.insertAppBtn = new System.Windows.Forms.Button();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointment.Location = new System.Drawing.Point(218, 9);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(220, 45);
            this.labelAppointment.TabIndex = 0;
            this.labelAppointment.Text = "Appointment";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(121)))));
            this.topPnl.Controls.Add(this.labelAppointment);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(657, 60);
            this.topPnl.TabIndex = 3;
            // 
            // appIdTb
            // 
            this.appIdTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appIdTb.Location = new System.Drawing.Point(141, 85);
            this.appIdTb.Name = "appIdTb";
            this.appIdTb.Size = new System.Drawing.Size(486, 22);
            this.appIdTb.TabIndex = 7;
            // 
            // appoIDLbl
            // 
            this.appoIDLbl.AutoSize = true;
            this.appoIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoIDLbl.Location = new System.Drawing.Point(15, 86);
            this.appoIDLbl.Name = "appoIDLbl";
            this.appoIDLbl.Size = new System.Drawing.Size(120, 21);
            this.appoIDLbl.TabIndex = 6;
            this.appoIDLbl.Text = "Appointment ID";
            // 
            // appPatNameTb
            // 
            this.appPatNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appPatNameTb.Location = new System.Drawing.Point(141, 126);
            this.appPatNameTb.Name = "appPatNameTb";
            this.appPatNameTb.Size = new System.Drawing.Size(486, 22);
            this.appPatNameTb.TabIndex = 9;
            // 
            // patientNameLbl
            // 
            this.patientNameLbl.AutoSize = true;
            this.patientNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLbl.Location = new System.Drawing.Point(15, 128);
            this.patientNameLbl.Name = "patientNameLbl";
            this.patientNameLbl.Size = new System.Drawing.Size(103, 21);
            this.patientNameLbl.TabIndex = 8;
            this.patientNameLbl.Text = "Patient Name";
            // 
            // appDocNameTb
            // 
            this.appDocNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDocNameTb.Location = new System.Drawing.Point(141, 167);
            this.appDocNameTb.Name = "appDocNameTb";
            this.appDocNameTb.Size = new System.Drawing.Size(486, 22);
            this.appDocNameTb.TabIndex = 11;
            // 
            // docNameLbl
            // 
            this.docNameLbl.AutoSize = true;
            this.docNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameLbl.Location = new System.Drawing.Point(15, 170);
            this.docNameLbl.Name = "docNameLbl";
            this.docNameLbl.Size = new System.Drawing.Size(103, 21);
            this.docNameLbl.TabIndex = 10;
            this.docNameLbl.Text = "Doctor Name";
            // 
            // dateCreatedLbl
            // 
            this.dateCreatedLbl.AutoSize = true;
            this.dateCreatedLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedLbl.Location = new System.Drawing.Point(15, 212);
            this.dateCreatedLbl.Name = "dateCreatedLbl";
            this.dateCreatedLbl.Size = new System.Drawing.Size(100, 21);
            this.dateCreatedLbl.TabIndex = 12;
            this.dateCreatedLbl.Text = "Date Created";
            // 
            // statusTb
            // 
            this.statusTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTb.Location = new System.Drawing.Point(141, 253);
            this.statusTb.Name = "statusTb";
            this.statusTb.Size = new System.Drawing.Size(486, 22);
            this.statusTb.TabIndex = 15;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(15, 254);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(52, 21);
            this.statusLbl.TabIndex = 14;
            this.statusLbl.Text = "Status";
            // 
            // appDatePckr
            // 
            this.appDatePckr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDatePckr.Location = new System.Drawing.Point(141, 208);
            this.appDatePckr.Name = "appDatePckr";
            this.appDatePckr.Size = new System.Drawing.Size(229, 26);
            this.appDatePckr.TabIndex = 16;
            // 
            // appGridView
            // 
            this.appGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appGridView.Location = new System.Drawing.Point(19, 367);
            this.appGridView.Name = "appGridView";
            this.appGridView.Size = new System.Drawing.Size(608, 158);
            this.appGridView.TabIndex = 22;
            // 
            // deleteAppBtn
            // 
            this.deleteAppBtn.BackColor = System.Drawing.Color.Red;
            this.deleteAppBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppBtn.Location = new System.Drawing.Point(315, 303);
            this.deleteAppBtn.Name = "deleteAppBtn";
            this.deleteAppBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteAppBtn.TabIndex = 21;
            this.deleteAppBtn.Text = "Delete";
            this.deleteAppBtn.UseVisualStyleBackColor = false;
            this.deleteAppBtn.Click += new System.EventHandler(this.deleteDocBtn_Click);
            // 
            // updateAppBtn
            // 
            this.updateAppBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppBtn.Location = new System.Drawing.Point(167, 303);
            this.updateAppBtn.Name = "updateAppBtn";
            this.updateAppBtn.Size = new System.Drawing.Size(126, 46);
            this.updateAppBtn.TabIndex = 20;
            this.updateAppBtn.Text = "Update";
            this.updateAppBtn.UseVisualStyleBackColor = true;
            this.updateAppBtn.Click += new System.EventHandler(this.updateDocBtn_Click);
            // 
            // insertAppBtn
            // 
            this.insertAppBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertAppBtn.Location = new System.Drawing.Point(19, 303);
            this.insertAppBtn.Name = "insertAppBtn";
            this.insertAppBtn.Size = new System.Drawing.Size(126, 46);
            this.insertAppBtn.TabIndex = 19;
            this.insertAppBtn.Text = "Insert";
            this.insertAppBtn.UseVisualStyleBackColor = true;
            this.insertAppBtn.Click += new System.EventHandler(this.insertDocBtn_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(239)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.appGridView);
            this.Controls.Add(this.deleteAppBtn);
            this.Controls.Add(this.updateAppBtn);
            this.Controls.Add(this.insertAppBtn);
            this.Controls.Add(this.appDatePckr);
            this.Controls.Add(this.statusTb);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.dateCreatedLbl);
            this.Controls.Add(this.appDocNameTb);
            this.Controls.Add(this.docNameLbl);
            this.Controls.Add(this.appPatNameTb);
            this.Controls.Add(this.patientNameLbl);
            this.Controls.Add(this.appIdTb);
            this.Controls.Add(this.appoIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.TextBox appIdTb;
        private System.Windows.Forms.Label appoIDLbl;
        private System.Windows.Forms.TextBox appPatNameTb;
        private System.Windows.Forms.Label patientNameLbl;
        private System.Windows.Forms.TextBox appDocNameTb;
        private System.Windows.Forms.Label docNameLbl;
        private System.Windows.Forms.Label dateCreatedLbl;
        private System.Windows.Forms.TextBox statusTb;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.DateTimePicker appDatePckr;
        private System.Windows.Forms.DataGridView appGridView;
        private System.Windows.Forms.Button deleteAppBtn;
        private System.Windows.Forms.Button updateAppBtn;
        private System.Windows.Forms.Button insertAppBtn;
    }
}
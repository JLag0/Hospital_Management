namespace Hospital_Management
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            this.topPnl = new System.Windows.Forms.Panel();
            this.labelDoctors = new System.Windows.Forms.Label();
            this.doctorIdTb = new System.Windows.Forms.TextBox();
            this.doctorIDLbl = new System.Windows.Forms.Label();
            this.doctorNameTb = new System.Windows.Forms.TextBox();
            this.doctorNameLbl = new System.Windows.Forms.Label();
            this.specialityTb = new System.Windows.Forms.TextBox();
            this.specialityLbl = new System.Windows.Forms.Label();
            this.docPhoneTb = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.departmentTb = new System.Windows.Forms.TextBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.deleteDocBtn = new System.Windows.Forms.Button();
            this.updateDocBtn = new System.Windows.Forms.Button();
            this.insertDocBtn = new System.Windows.Forms.Button();
            this.docGridView = new System.Windows.Forms.DataGridView();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.topPnl.Controls.Add(this.labelDoctors);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(657, 60);
            this.topPnl.TabIndex = 2;
            // 
            // labelDoctors
            // 
            this.labelDoctors.AutoSize = true;
            this.labelDoctors.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctors.Location = new System.Drawing.Point(258, 9);
            this.labelDoctors.Name = "labelDoctors";
            this.labelDoctors.Size = new System.Drawing.Size(138, 45);
            this.labelDoctors.TabIndex = 0;
            this.labelDoctors.Text = "Doctors";
            // 
            // doctorIdTb
            // 
            this.doctorIdTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIdTb.Location = new System.Drawing.Point(141, 95);
            this.doctorIdTb.Name = "doctorIdTb";
            this.doctorIdTb.Size = new System.Drawing.Size(464, 22);
            this.doctorIdTb.TabIndex = 5;
            // 
            // doctorIDLbl
            // 
            this.doctorIDLbl.AutoSize = true;
            this.doctorIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorIDLbl.Location = new System.Drawing.Point(24, 96);
            this.doctorIDLbl.Name = "doctorIDLbl";
            this.doctorIDLbl.Size = new System.Drawing.Size(76, 21);
            this.doctorIDLbl.TabIndex = 4;
            this.doctorIDLbl.Text = "Doctor ID";
            // 
            // doctorNameTb
            // 
            this.doctorNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameTb.Location = new System.Drawing.Point(141, 141);
            this.doctorNameTb.Name = "doctorNameTb";
            this.doctorNameTb.Size = new System.Drawing.Size(464, 22);
            this.doctorNameTb.TabIndex = 7;
            // 
            // doctorNameLbl
            // 
            this.doctorNameLbl.AutoSize = true;
            this.doctorNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorNameLbl.Location = new System.Drawing.Point(24, 142);
            this.doctorNameLbl.Name = "doctorNameLbl";
            this.doctorNameLbl.Size = new System.Drawing.Size(103, 21);
            this.doctorNameLbl.TabIndex = 6;
            this.doctorNameLbl.Text = "Doctor Name";
            // 
            // specialityTb
            // 
            this.specialityTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialityTb.Location = new System.Drawing.Point(141, 187);
            this.specialityTb.Name = "specialityTb";
            this.specialityTb.Size = new System.Drawing.Size(464, 22);
            this.specialityTb.TabIndex = 9;
            // 
            // specialityLbl
            // 
            this.specialityLbl.AutoSize = true;
            this.specialityLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialityLbl.Location = new System.Drawing.Point(24, 188);
            this.specialityLbl.Name = "specialityLbl";
            this.specialityLbl.Size = new System.Drawing.Size(76, 21);
            this.specialityLbl.TabIndex = 8;
            this.specialityLbl.Text = "Speciality";
            // 
            // docPhoneTb
            // 
            this.docPhoneTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docPhoneTb.Location = new System.Drawing.Point(141, 233);
            this.docPhoneTb.Name = "docPhoneTb";
            this.docPhoneTb.Size = new System.Drawing.Size(464, 22);
            this.docPhoneTb.TabIndex = 11;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(24, 234);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(82, 21);
            this.phoneLbl.TabIndex = 10;
            this.phoneLbl.Text = "Phone No.";
            // 
            // departmentTb
            // 
            this.departmentTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentTb.Location = new System.Drawing.Point(141, 279);
            this.departmentTb.Name = "departmentTb";
            this.departmentTb.Size = new System.Drawing.Size(464, 22);
            this.departmentTb.TabIndex = 13;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLbl.Location = new System.Drawing.Point(24, 280);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(93, 21);
            this.departmentLbl.TabIndex = 12;
            this.departmentLbl.Text = "Department";
            // 
            // deleteDocBtn
            // 
            this.deleteDocBtn.BackColor = System.Drawing.Color.Red;
            this.deleteDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDocBtn.Location = new System.Drawing.Point(336, 320);
            this.deleteDocBtn.Name = "deleteDocBtn";
            this.deleteDocBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteDocBtn.TabIndex = 17;
            this.deleteDocBtn.Text = "Delete";
            this.deleteDocBtn.UseVisualStyleBackColor = false;
            this.deleteDocBtn.Click += new System.EventHandler(this.deleteDocBtn_Click);
            // 
            // updateDocBtn
            // 
            this.updateDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDocBtn.Location = new System.Drawing.Point(188, 320);
            this.updateDocBtn.Name = "updateDocBtn";
            this.updateDocBtn.Size = new System.Drawing.Size(126, 46);
            this.updateDocBtn.TabIndex = 16;
            this.updateDocBtn.Text = "Update";
            this.updateDocBtn.UseVisualStyleBackColor = true;
            this.updateDocBtn.Click += new System.EventHandler(this.updateDocBtn_Click);
            // 
            // insertDocBtn
            // 
            this.insertDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDocBtn.Location = new System.Drawing.Point(40, 320);
            this.insertDocBtn.Name = "insertDocBtn";
            this.insertDocBtn.Size = new System.Drawing.Size(126, 46);
            this.insertDocBtn.TabIndex = 15;
            this.insertDocBtn.Text = "Insert";
            this.insertDocBtn.UseVisualStyleBackColor = true;
            this.insertDocBtn.Click += new System.EventHandler(this.insertDocBtn_Click);
            // 
            // docGridView
            // 
            this.docGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.docGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.docGridView.Location = new System.Drawing.Point(40, 384);
            this.docGridView.Name = "docGridView";
            this.docGridView.Size = new System.Drawing.Size(577, 150);
            this.docGridView.TabIndex = 18;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.docGridView);
            this.Controls.Add(this.deleteDocBtn);
            this.Controls.Add(this.updateDocBtn);
            this.Controls.Add(this.insertDocBtn);
            this.Controls.Add(this.departmentTb);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.docPhoneTb);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.specialityTb);
            this.Controls.Add(this.specialityLbl);
            this.Controls.Add(this.doctorNameTb);
            this.Controls.Add(this.doctorNameLbl);
            this.Controls.Add(this.doctorIdTb);
            this.Controls.Add(this.doctorIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.TextBox doctorIdTb;
        private System.Windows.Forms.Label doctorIDLbl;
        private System.Windows.Forms.TextBox doctorNameTb;
        private System.Windows.Forms.Label doctorNameLbl;
        private System.Windows.Forms.TextBox specialityTb;
        private System.Windows.Forms.Label specialityLbl;
        private System.Windows.Forms.TextBox docPhoneTb;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox departmentTb;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.Button deleteDocBtn;
        private System.Windows.Forms.Button updateDocBtn;
        private System.Windows.Forms.Button insertDocBtn;
        private System.Windows.Forms.DataGridView docGridView;
    }
}
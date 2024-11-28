namespace Hospital_Management
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.topPnl = new System.Windows.Forms.Panel();
            this.labelPatient = new System.Windows.Forms.Label();
            this.patientIDLbl = new System.Windows.Forms.Label();
            this.patientIDtb = new System.Windows.Forms.TextBox();
            this.patientNameLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.adressLbl = new System.Windows.Forms.Label();
            this.patientNametb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.genderTb = new System.Windows.Forms.TextBox();
            this.adressTb = new System.Windows.Forms.TextBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.patGridView = new System.Windows.Forms.DataGridView();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(216)))), ((int)(((byte)(20)))));
            this.topPnl.Controls.Add(this.labelPatient);
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(655, 60);
            this.topPnl.TabIndex = 1;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.Location = new System.Drawing.Point(258, 9);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(139, 45);
            this.labelPatient.TabIndex = 0;
            this.labelPatient.Text = "Patients";
            // 
            // patientIDLbl
            // 
            this.patientIDLbl.AutoSize = true;
            this.patientIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDLbl.Location = new System.Drawing.Point(26, 98);
            this.patientIDLbl.Name = "patientIDLbl";
            this.patientIDLbl.Size = new System.Drawing.Size(76, 21);
            this.patientIDLbl.TabIndex = 2;
            this.patientIDLbl.Text = "Patient ID";
            // 
            // patientIDtb
            // 
            this.patientIDtb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDtb.Location = new System.Drawing.Point(143, 98);
            this.patientIDtb.Name = "patientIDtb";
            this.patientIDtb.Size = new System.Drawing.Size(464, 22);
            this.patientIDtb.TabIndex = 3;
            // 
            // patientNameLbl
            // 
            this.patientNameLbl.AutoSize = true;
            this.patientNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNameLbl.Location = new System.Drawing.Point(26, 143);
            this.patientNameLbl.Name = "patientNameLbl";
            this.patientNameLbl.Size = new System.Drawing.Size(103, 21);
            this.patientNameLbl.TabIndex = 4;
            this.patientNameLbl.Text = "Patient Name";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLbl.Location = new System.Drawing.Point(26, 188);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(37, 21);
            this.ageLbl.TabIndex = 5;
            this.ageLbl.Text = "Age";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.Location = new System.Drawing.Point(26, 233);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(61, 21);
            this.genderLbl.TabIndex = 6;
            this.genderLbl.Text = "Gender";
            // 
            // adressLbl
            // 
            this.adressLbl.AutoSize = true;
            this.adressLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLbl.Location = new System.Drawing.Point(26, 278);
            this.adressLbl.Name = "adressLbl";
            this.adressLbl.Size = new System.Drawing.Size(57, 21);
            this.adressLbl.TabIndex = 7;
            this.adressLbl.Text = "Adress";
            // 
            // patientNametb
            // 
            this.patientNametb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNametb.Location = new System.Drawing.Point(143, 143);
            this.patientNametb.Name = "patientNametb";
            this.patientNametb.Size = new System.Drawing.Size(464, 22);
            this.patientNametb.TabIndex = 8;
            // 
            // ageTb
            // 
            this.ageTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTb.Location = new System.Drawing.Point(143, 188);
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(464, 22);
            this.ageTb.TabIndex = 9;
            // 
            // genderTb
            // 
            this.genderTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTb.Location = new System.Drawing.Point(143, 233);
            this.genderTb.Name = "genderTb";
            this.genderTb.Size = new System.Drawing.Size(464, 22);
            this.genderTb.TabIndex = 10;
            // 
            // adressTb
            // 
            this.adressTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressTb.Location = new System.Drawing.Point(143, 278);
            this.adressTb.Name = "adressTb";
            this.adressTb.Size = new System.Drawing.Size(464, 22);
            this.adressTb.TabIndex = 11;
            // 
            // insertBtn
            // 
            this.insertBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.insertBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBtn.Location = new System.Drawing.Point(38, 321);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(126, 46);
            this.insertBtn.TabIndex = 12;
            this.insertBtn.Text = "Insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(186, 321);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(126, 46);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(334, 321);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // patGridView
            // 
            this.patGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patGridView.Location = new System.Drawing.Point(40, 384);
            this.patGridView.Name = "patGridView";
            this.patGridView.Size = new System.Drawing.Size(577, 150);
            this.patGridView.TabIndex = 15;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(156)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.patGridView);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.adressTb);
            this.Controls.Add(this.genderTb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.patientNametb);
            this.Controls.Add(this.adressLbl);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.patientNameLbl);
            this.Controls.Add(this.patientIDtb);
            this.Controls.Add(this.patientIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Patients_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label patientIDLbl;
        private System.Windows.Forms.TextBox patientIDtb;
        private System.Windows.Forms.Label patientNameLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label adressLbl;
        private System.Windows.Forms.TextBox patientNametb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.TextBox genderTb;
        private System.Windows.Forms.TextBox adressTb;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView patGridView;
    }
}
namespace Hospital_Management
{
    partial class MedicalRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalRecord));
            this.labelMedicalRecord = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.medRecIdTb = new System.Windows.Forms.TextBox();
            this.appoIDLbl = new System.Windows.Forms.Label();
            this.mrPatNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mrDocNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mrNurTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mrDiagTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mrPresTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mrTreatTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.medRecGridView = new System.Windows.Forms.DataGridView();
            this.deleteMRBtn = new System.Windows.Forms.Button();
            this.updateMRBtn = new System.Windows.Forms.Button();
            this.insertMRBtn = new System.Windows.Forms.Button();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medRecGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMedicalRecord
            // 
            this.labelMedicalRecord.AutoSize = true;
            this.labelMedicalRecord.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedicalRecord.Location = new System.Drawing.Point(214, 9);
            this.labelMedicalRecord.Name = "labelMedicalRecord";
            this.labelMedicalRecord.Size = new System.Drawing.Size(252, 45);
            this.labelMedicalRecord.TabIndex = 0;
            this.labelMedicalRecord.Text = "Medical Record";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(219)))), ((int)(((byte)(34)))));
            this.topPnl.Controls.Add(this.labelMedicalRecord);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(681, 60);
            this.topPnl.TabIndex = 4;
            // 
            // medRecIdTb
            // 
            this.medRecIdTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medRecIdTb.Location = new System.Drawing.Point(156, 90);
            this.medRecIdTb.Name = "medRecIdTb";
            this.medRecIdTb.Size = new System.Drawing.Size(486, 22);
            this.medRecIdTb.TabIndex = 9;
            // 
            // appoIDLbl
            // 
            this.appoIDLbl.AutoSize = true;
            this.appoIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoIDLbl.Location = new System.Drawing.Point(30, 91);
            this.appoIDLbl.Name = "appoIDLbl";
            this.appoIDLbl.Size = new System.Drawing.Size(113, 21);
            this.appoIDLbl.TabIndex = 8;
            this.appoIDLbl.Text = "Med Record ID";
            // 
            // mrPatNameTb
            // 
            this.mrPatNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrPatNameTb.Location = new System.Drawing.Point(156, 128);
            this.mrPatNameTb.Name = "mrPatNameTb";
            this.mrPatNameTb.Size = new System.Drawing.Size(486, 22);
            this.mrPatNameTb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient Name";
            // 
            // mrDocNameTb
            // 
            this.mrDocNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrDocNameTb.Location = new System.Drawing.Point(156, 171);
            this.mrDocNameTb.Name = "mrDocNameTb";
            this.mrDocNameTb.Size = new System.Drawing.Size(486, 22);
            this.mrDocNameTb.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Doctor Name";
            // 
            // mrNurTb
            // 
            this.mrNurTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrNurTb.Location = new System.Drawing.Point(156, 213);
            this.mrNurTb.Name = "mrNurTb";
            this.mrNurTb.Size = new System.Drawing.Size(486, 22);
            this.mrNurTb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nurse";
            // 
            // mrDiagTb
            // 
            this.mrDiagTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrDiagTb.Location = new System.Drawing.Point(156, 259);
            this.mrDiagTb.Name = "mrDiagTb";
            this.mrDiagTb.Size = new System.Drawing.Size(486, 22);
            this.mrDiagTb.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diagnosis";
            // 
            // mrPresTb
            // 
            this.mrPresTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrPresTb.Location = new System.Drawing.Point(156, 306);
            this.mrPresTb.Name = "mrPresTb";
            this.mrPresTb.Size = new System.Drawing.Size(486, 22);
            this.mrPresTb.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prescription";
            // 
            // mrTreatTb
            // 
            this.mrTreatTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrTreatTb.Location = new System.Drawing.Point(156, 351);
            this.mrTreatTb.Name = "mrTreatTb";
            this.mrTreatTb.Size = new System.Drawing.Size(486, 22);
            this.mrTreatTb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Treatment";
            // 
            // medRecGridView
            // 
            this.medRecGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medRecGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medRecGridView.Location = new System.Drawing.Point(34, 456);
            this.medRecGridView.Name = "medRecGridView";
            this.medRecGridView.Size = new System.Drawing.Size(608, 158);
            this.medRecGridView.TabIndex = 26;
            // 
            // deleteMRBtn
            // 
            this.deleteMRBtn.BackColor = System.Drawing.Color.Red;
            this.deleteMRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMRBtn.Location = new System.Drawing.Point(330, 392);
            this.deleteMRBtn.Name = "deleteMRBtn";
            this.deleteMRBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteMRBtn.TabIndex = 25;
            this.deleteMRBtn.Text = "Delete";
            this.deleteMRBtn.UseVisualStyleBackColor = false;
            this.deleteMRBtn.Click += new System.EventHandler(this.deleteMRBtn_Click);
            // 
            // updateMRBtn
            // 
            this.updateMRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMRBtn.Location = new System.Drawing.Point(182, 392);
            this.updateMRBtn.Name = "updateMRBtn";
            this.updateMRBtn.Size = new System.Drawing.Size(126, 46);
            this.updateMRBtn.TabIndex = 24;
            this.updateMRBtn.Text = "Update";
            this.updateMRBtn.UseVisualStyleBackColor = true;
            this.updateMRBtn.Click += new System.EventHandler(this.updateMRBtn_Click);
            // 
            // insertMRBtn
            // 
            this.insertMRBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertMRBtn.Location = new System.Drawing.Point(34, 392);
            this.insertMRBtn.Name = "insertMRBtn";
            this.insertMRBtn.Size = new System.Drawing.Size(126, 46);
            this.insertMRBtn.TabIndex = 23;
            this.insertMRBtn.Text = "Insert";
            this.insertMRBtn.UseVisualStyleBackColor = true;
            this.insertMRBtn.Click += new System.EventHandler(this.insertMRBtn_Click);
            // 
            // MedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.ClientSize = new System.Drawing.Size(681, 644);
            this.Controls.Add(this.medRecGridView);
            this.Controls.Add(this.deleteMRBtn);
            this.Controls.Add(this.updateMRBtn);
            this.Controls.Add(this.insertMRBtn);
            this.Controls.Add(this.mrTreatTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mrPresTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mrDiagTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mrNurTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mrDocNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mrPatNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medRecIdTb);
            this.Controls.Add(this.appoIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MedicalRecord";
            this.Text = "MedicalRecords";
            this.Load += new System.EventHandler(this.MedicalRecord_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medRecGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMedicalRecord;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.TextBox medRecIdTb;
        private System.Windows.Forms.Label appoIDLbl;
        private System.Windows.Forms.TextBox mrPatNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mrDocNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mrNurTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mrDiagTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mrPresTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mrTreatTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView medRecGridView;
        private System.Windows.Forms.Button deleteMRBtn;
        private System.Windows.Forms.Button updateMRBtn;
        private System.Windows.Forms.Button insertMRBtn;
    }
}
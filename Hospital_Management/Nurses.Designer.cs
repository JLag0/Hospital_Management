namespace Hospital_Management
{
    partial class Nurses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nurses));
            this.labelNurses = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.nurseIdTb = new System.Windows.Forms.TextBox();
            this.nurseIDLbl = new System.Windows.Forms.Label();
            this.nurseNameTb = new System.Windows.Forms.TextBox();
            this.nurseNameLbl = new System.Windows.Forms.Label();
            this.nurPhoneTb = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nurDepartmentTb = new System.Windows.Forms.TextBox();
            this.departmentLbl = new System.Windows.Forms.Label();
            this.nurGridView = new System.Windows.Forms.DataGridView();
            this.deleteNurBtn = new System.Windows.Forms.Button();
            this.updateNurBtn = new System.Windows.Forms.Button();
            this.insertNurBtn = new System.Windows.Forms.Button();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNurses
            // 
            this.labelNurses.AutoSize = true;
            this.labelNurses.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNurses.Location = new System.Drawing.Point(267, 9);
            this.labelNurses.Name = "labelNurses";
            this.labelNurses.Size = new System.Drawing.Size(122, 45);
            this.labelNurses.TabIndex = 0;
            this.labelNurses.Text = "Nurses";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(144)))));
            this.topPnl.Controls.Add(this.labelNurses);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(657, 60);
            this.topPnl.TabIndex = 3;
            // 
            // nurseIdTb
            // 
            this.nurseIdTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIdTb.Location = new System.Drawing.Point(141, 96);
            this.nurseIdTb.Name = "nurseIdTb";
            this.nurseIdTb.Size = new System.Drawing.Size(464, 22);
            this.nurseIdTb.TabIndex = 7;
            // 
            // nurseIDLbl
            // 
            this.nurseIDLbl.AutoSize = true;
            this.nurseIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseIDLbl.Location = new System.Drawing.Point(24, 97);
            this.nurseIDLbl.Name = "nurseIDLbl";
            this.nurseIDLbl.Size = new System.Drawing.Size(71, 21);
            this.nurseIDLbl.TabIndex = 6;
            this.nurseIDLbl.Text = "Nurse ID";
            // 
            // nurseNameTb
            // 
            this.nurseNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameTb.Location = new System.Drawing.Point(141, 139);
            this.nurseNameTb.Name = "nurseNameTb";
            this.nurseNameTb.Size = new System.Drawing.Size(464, 22);
            this.nurseNameTb.TabIndex = 9;
            // 
            // nurseNameLbl
            // 
            this.nurseNameLbl.AutoSize = true;
            this.nurseNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurseNameLbl.Location = new System.Drawing.Point(24, 140);
            this.nurseNameLbl.Name = "nurseNameLbl";
            this.nurseNameLbl.Size = new System.Drawing.Size(98, 21);
            this.nurseNameLbl.TabIndex = 8;
            this.nurseNameLbl.Text = "Nurse Name";
            // 
            // nurPhoneTb
            // 
            this.nurPhoneTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurPhoneTb.Location = new System.Drawing.Point(141, 182);
            this.nurPhoneTb.Name = "nurPhoneTb";
            this.nurPhoneTb.Size = new System.Drawing.Size(464, 22);
            this.nurPhoneTb.TabIndex = 11;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(24, 183);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(82, 21);
            this.phoneLbl.TabIndex = 10;
            this.phoneLbl.Text = "Phone No.";
            // 
            // nurDepartmentTb
            // 
            this.nurDepartmentTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nurDepartmentTb.Location = new System.Drawing.Point(141, 225);
            this.nurDepartmentTb.Name = "nurDepartmentTb";
            this.nurDepartmentTb.Size = new System.Drawing.Size(464, 22);
            this.nurDepartmentTb.TabIndex = 13;
            // 
            // departmentLbl
            // 
            this.departmentLbl.AutoSize = true;
            this.departmentLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLbl.Location = new System.Drawing.Point(24, 226);
            this.departmentLbl.Name = "departmentLbl";
            this.departmentLbl.Size = new System.Drawing.Size(93, 21);
            this.departmentLbl.TabIndex = 12;
            this.departmentLbl.Text = "Department";
            // 
            // nurGridView
            // 
            this.nurGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nurGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nurGridView.Location = new System.Drawing.Point(28, 338);
            this.nurGridView.Name = "nurGridView";
            this.nurGridView.Size = new System.Drawing.Size(577, 183);
            this.nurGridView.TabIndex = 22;
            // 
            // deleteNurBtn
            // 
            this.deleteNurBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNurBtn.Location = new System.Drawing.Point(324, 274);
            this.deleteNurBtn.Name = "deleteNurBtn";
            this.deleteNurBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteNurBtn.TabIndex = 21;
            this.deleteNurBtn.Text = "Delete";
            this.deleteNurBtn.UseVisualStyleBackColor = true;
            this.deleteNurBtn.Click += new System.EventHandler(this.deleteNurBtn_Click);
            // 
            // updateNurBtn
            // 
            this.updateNurBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateNurBtn.Location = new System.Drawing.Point(176, 274);
            this.updateNurBtn.Name = "updateNurBtn";
            this.updateNurBtn.Size = new System.Drawing.Size(126, 46);
            this.updateNurBtn.TabIndex = 20;
            this.updateNurBtn.Text = "Update";
            this.updateNurBtn.UseVisualStyleBackColor = true;
            this.updateNurBtn.Click += new System.EventHandler(this.updateNurBtn_Click);
            // 
            // insertNurBtn
            // 
            this.insertNurBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertNurBtn.Location = new System.Drawing.Point(28, 274);
            this.insertNurBtn.Name = "insertNurBtn";
            this.insertNurBtn.Size = new System.Drawing.Size(126, 46);
            this.insertNurBtn.TabIndex = 19;
            this.insertNurBtn.Text = "Insert";
            this.insertNurBtn.UseVisualStyleBackColor = true;
            this.insertNurBtn.Click += new System.EventHandler(this.insertNurBtn_Click);
            // 
            // Nurses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(162)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.nurGridView);
            this.Controls.Add(this.deleteNurBtn);
            this.Controls.Add(this.updateNurBtn);
            this.Controls.Add(this.insertNurBtn);
            this.Controls.Add(this.nurDepartmentTb);
            this.Controls.Add(this.departmentLbl);
            this.Controls.Add(this.nurPhoneTb);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.nurseNameTb);
            this.Controls.Add(this.nurseNameLbl);
            this.Controls.Add(this.nurseIdTb);
            this.Controls.Add(this.nurseIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Nurses";
            this.Text = "Nurses";
            this.Load += new System.EventHandler(this.Nurses_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nurGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNurses;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.TextBox nurseIdTb;
        private System.Windows.Forms.Label nurseIDLbl;
        private System.Windows.Forms.TextBox nurseNameTb;
        private System.Windows.Forms.Label nurseNameLbl;
        private System.Windows.Forms.TextBox nurPhoneTb;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nurDepartmentTb;
        private System.Windows.Forms.Label departmentLbl;
        private System.Windows.Forms.DataGridView nurGridView;
        private System.Windows.Forms.Button deleteNurBtn;
        private System.Windows.Forms.Button updateNurBtn;
        private System.Windows.Forms.Button insertNurBtn;
    }
}
namespace Hospital_Management
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.labelDoctors = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.billIdTb = new System.Windows.Forms.TextBox();
            this.billIDLbl = new System.Windows.Forms.Label();
            this.patNameTb = new System.Windows.Forms.TextBox();
            this.patNameLbl = new System.Windows.Forms.Label();
            this.amountTb = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.statusTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.billGridView = new System.Windows.Forms.DataGridView();
            this.deleteDocBtn = new System.Windows.Forms.Button();
            this.updateDocBtn = new System.Windows.Forms.Button();
            this.insertDocBtn = new System.Windows.Forms.Button();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoctors
            // 
            this.labelDoctors.AutoSize = true;
            this.labelDoctors.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctors.Location = new System.Drawing.Point(294, 9);
            this.labelDoctors.Name = "labelDoctors";
            this.labelDoctors.Size = new System.Drawing.Size(68, 45);
            this.labelDoctors.TabIndex = 0;
            this.labelDoctors.Text = "Bill";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(92)))), ((int)(((byte)(252)))));
            this.topPnl.Controls.Add(this.labelDoctors);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(657, 60);
            this.topPnl.TabIndex = 3;
            // 
            // billIdTb
            // 
            this.billIdTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIdTb.Location = new System.Drawing.Point(154, 93);
            this.billIdTb.Name = "billIdTb";
            this.billIdTb.Size = new System.Drawing.Size(464, 22);
            this.billIdTb.TabIndex = 7;
            // 
            // billIDLbl
            // 
            this.billIDLbl.AutoSize = true;
            this.billIDLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billIDLbl.Location = new System.Drawing.Point(37, 94);
            this.billIDLbl.Name = "billIDLbl";
            this.billIDLbl.Size = new System.Drawing.Size(50, 21);
            this.billIDLbl.TabIndex = 6;
            this.billIDLbl.Text = "Bill ID";
            // 
            // patNameTb
            // 
            this.patNameTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameTb.Location = new System.Drawing.Point(154, 137);
            this.patNameTb.Name = "patNameTb";
            this.patNameTb.Size = new System.Drawing.Size(464, 22);
            this.patNameTb.TabIndex = 9;
            // 
            // patNameLbl
            // 
            this.patNameLbl.AutoSize = true;
            this.patNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patNameLbl.Location = new System.Drawing.Point(37, 138);
            this.patNameLbl.Name = "patNameLbl";
            this.patNameLbl.Size = new System.Drawing.Size(103, 21);
            this.patNameLbl.TabIndex = 8;
            this.patNameLbl.Text = "Patient Name";
            // 
            // amountTb
            // 
            this.amountTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTb.Location = new System.Drawing.Point(154, 181);
            this.amountTb.Name = "amountTb";
            this.amountTb.Size = new System.Drawing.Size(464, 22);
            this.amountTb.TabIndex = 11;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.Location = new System.Drawing.Point(37, 182);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(66, 21);
            this.amountLbl.TabIndex = 10;
            this.amountLbl.Text = "Amount";
            // 
            // statusTb
            // 
            this.statusTb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTb.Location = new System.Drawing.Point(154, 225);
            this.statusTb.Name = "statusTb";
            this.statusTb.Size = new System.Drawing.Size(464, 22);
            this.statusTb.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // billGridView
            // 
            this.billGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billGridView.Location = new System.Drawing.Point(41, 336);
            this.billGridView.Name = "billGridView";
            this.billGridView.Size = new System.Drawing.Size(577, 177);
            this.billGridView.TabIndex = 22;
            // 
            // deleteDocBtn
            // 
            this.deleteDocBtn.BackColor = System.Drawing.Color.Red;
            this.deleteDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDocBtn.Location = new System.Drawing.Point(337, 272);
            this.deleteDocBtn.Name = "deleteDocBtn";
            this.deleteDocBtn.Size = new System.Drawing.Size(126, 46);
            this.deleteDocBtn.TabIndex = 21;
            this.deleteDocBtn.Text = "Delete";
            this.deleteDocBtn.UseVisualStyleBackColor = false;
            this.deleteDocBtn.Click += new System.EventHandler(this.deleteDocBtn_Click);
            // 
            // updateDocBtn
            // 
            this.updateDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDocBtn.Location = new System.Drawing.Point(189, 272);
            this.updateDocBtn.Name = "updateDocBtn";
            this.updateDocBtn.Size = new System.Drawing.Size(126, 46);
            this.updateDocBtn.TabIndex = 20;
            this.updateDocBtn.Text = "Update";
            this.updateDocBtn.UseVisualStyleBackColor = true;
            this.updateDocBtn.Click += new System.EventHandler(this.updateDocBtn_Click);
            // 
            // insertDocBtn
            // 
            this.insertDocBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertDocBtn.Location = new System.Drawing.Point(41, 272);
            this.insertDocBtn.Name = "insertDocBtn";
            this.insertDocBtn.Size = new System.Drawing.Size(126, 46);
            this.insertDocBtn.TabIndex = 19;
            this.insertDocBtn.Text = "Insert";
            this.insertDocBtn.UseVisualStyleBackColor = true;
            this.insertDocBtn.Click += new System.EventHandler(this.insertDocBtn_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 546);
            this.Controls.Add(this.billGridView);
            this.Controls.Add(this.deleteDocBtn);
            this.Controls.Add(this.updateDocBtn);
            this.Controls.Add(this.insertDocBtn);
            this.Controls.Add(this.statusTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTb);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.patNameTb);
            this.Controls.Add(this.patNameLbl);
            this.Controls.Add(this.billIdTb);
            this.Controls.Add(this.billIDLbl);
            this.Controls.Add(this.topPnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillForm";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.BillForm_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDoctors;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.TextBox billIdTb;
        private System.Windows.Forms.Label billIDLbl;
        private System.Windows.Forms.TextBox patNameTb;
        private System.Windows.Forms.Label patNameLbl;
        private System.Windows.Forms.TextBox amountTb;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TextBox statusTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView billGridView;
        private System.Windows.Forms.Button deleteDocBtn;
        private System.Windows.Forms.Button updateDocBtn;
        private System.Windows.Forms.Button insertDocBtn;
    }
}
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

namespace Hospital_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

       
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text == "admin" && passwordTextbox.Text == "1234")
            {
                Main mn = new Main();
                mn.Show();
            }
            else if (usernameTextbox.Text != "acdb" || passwordTextbox.Text != "1234")
            {
                MessageBox.Show("Invalid username or password");
            }
        }




















        // Inside LoginForm.cs
        private void LoginPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom paint logic here
            // Example: e.Graphics.DrawRectangle(Pens.Black, 0, 0, loginPanel.Width - 1, loginPanel.Height - 1);
        }
        // Event handler for the Load event of the form
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Add any initialization code if needed
        }

        // Event handler for the TextChanged event of the password textbox
        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            // Add any logic you need for this event
        }
        
    }
}
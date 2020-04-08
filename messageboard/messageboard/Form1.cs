using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messageboard
{
    public partial class Form1 : Form
    {
        public static String userName;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userName = txtUsername.Text;
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtUsername.Text != txtPassword.Text)
            {      
                MessageBox.Show("Username/Password Incorrect");
            }
            else 
            {
                this.Hide();
                messageboard_form newForm = new messageboard_form();
                newForm.Show();
            } 
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC_TEST.views
{
    
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        string name = "admin";
        string password = "admin";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Empty data.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Empty data.");
                txtPassword.Focus();
                return;
            }
            if(txtUsername.Text == name && txtPassword.Text == password)
            {
                MessageBox.Show("YEAH!");
                
            }
            else
            {
                MessageBox.Show("Please try again!");
                
            }

        }
    }
}

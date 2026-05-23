using NPIC_TEST.NPIC_TESTDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        bool validation()
        {
            UsersTableAdapter dataset = new UsersTableAdapter();
            using (DataTable dt = dataset.GetData())
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtUsername.Text == dr["username"].ToString() &&
                        txtPassword.Text == dr["password"].ToString() &&
                        !Convert.ToBoolean(dr["disable"]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
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
            if(validation())
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

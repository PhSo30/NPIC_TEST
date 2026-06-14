using NPIC_TEST.NPIC_TESTDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;



namespace NPIC_TEST.views
{
    
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        // @TODO: Refactor this method to use Dapper instead of DataTable for better performance and cleaner code.

        //bool authen()
        //{
        //    UsersTableAdapter adapter = new UsersTableAdapter();
        //    using (DataTable dt = adapter.GetDataByUname(txtUsername.Text.Trim()))
        //    {
        //        DataRow dataRow = dt.Rows[0];
        //        if (dataRow["Password"].ToString() == txtPassword.Text.Trim() &&
        //            !Convert.ToBoolean(dataRow["disable"]))
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
        //bool authen()
        //{
        //    using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NPIC_TEST.Properties.Settings.NPIC_TESTConnectionString"].ConnectionString))
        //    {
        //        var user = conn.QuerySingleOrDefault("SELECT * FROM Users WHERE Username = @Username", new { Username = txtUsername.Text.Trim() });
        //        if (user != null)
        //        {
        //            if (user.password == txtPassword.Text.Trim() && !user.disable)
        //            {
        //                return true;
        //            }
        //        }
        //    } return false;
            
        //}
        bool authen()
        {
            this.usersBindingSource.Filter = "username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "' AND disable = false";
            if(usersBindingSource.Count > 0 )
            {
                return true;
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
            if(authen())
            {
                MessageBox.Show("YEAH!");
                
            }
            else
            {
                MessageBox.Show("Please try again!");
                
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            Form registerForm = new registerForm();
            registerForm.Show();
            
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_TESTDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.nPIC_TESTDataSet.Users);

        }
    }
}

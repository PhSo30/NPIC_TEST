using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC_TEST.views.page
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_TESTDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.nPIC_TESTDataSet.Users);
            

        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.AddNew();
            disableCheckBox.Checked = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void picturePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Image";
            dialog.Multiselect = false;
            dialog.Filter = "Image PING | *.png";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                picturePictureBox.ImageLocation = dialog.FileName;
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);
            MessageBox.Show("Saved Sucessful!");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_search.Text))
            {
                this.usersBindingSource.Filter = "id=" + Convert.ToInt32(txt_search.Text);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersBindingSource.RemoveCurrent();
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);
                MessageBox.Show("Removed Sucessful!");

            }
            catch(Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}

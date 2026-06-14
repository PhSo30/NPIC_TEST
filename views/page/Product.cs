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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void productBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);

        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_TESTDataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.nPIC_TESTDataSet.category);
            // TODO: This line of code loads data into the 'nPIC_TESTDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.nPIC_TESTDataSet.product);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.productBindingSource.AddNew();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                this.productBindingSource.RemoveCurrent();
                this.productBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.nPIC_TESTDataSet);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Image";
            dialog.Multiselect = false;
            dialog.Filter = "Image PING | *.png; *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.ImageLocation = dialog.FileName;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.productBindingSource.Filter = "id = " + int.Parse(txt_search.Text);
        }
    }
}

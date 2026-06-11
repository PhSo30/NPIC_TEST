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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nPIC_TESTDataSet.AdministrativeBoundaries' table. You can move, or remove it, as needed.
            this.administrativeBoundariesTableAdapter.Fill(this.nPIC_TESTDataSet.AdministrativeBoundaries);
            this.administrativeBoundariesBindingSource.Filter = "Code is Null";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.administrativeBoundariesBindingSource1.Filter = "Code = " + Convert.ToInt32(comboBox1.SelectedValue) + ")";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.administrativeBoundariesBindingSource2.Filter = "Code = " + Convert.ToInt32(comboBox2.SelectedValue) + ")";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.administrativeBoundariesBindingSource3.Filter = "Code = " + Convert.ToInt32(comboBox3.SelectedValue) + ")";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

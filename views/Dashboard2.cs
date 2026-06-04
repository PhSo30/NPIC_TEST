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
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

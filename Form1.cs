using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPIC_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void fucnDelete()
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == "")
            {
                fucnDelete();
                return;
                
            }
            if (textBox1.Text == "Clear")
            {
                label1.Text = string.Empty;
                fucnDelete();
            }
            else
            {
                label1.Text += textBox1.Text + "\n";
                fucnDelete();
            }
            
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}

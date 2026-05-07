using NPIC_TEST.Model;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            List<Student> list = new List<Student>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(txtID.Text.Trim() == string.Empty || txtUsername.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Must fill all the box");
                return;
            }
            if (txtID.Text.All(char.IsDigit) || txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Id or Phone must be only number");
                return;
            }
            Student student = new Student();
            student.Id = int.Parse(txtID.Text.Trim());
            student.Username = txtUsername.Text;
            student.Phone = txtPhone.Text.Trim();
            

            dataGridView1.Rows.Add();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        List<Student> list = new List<Student>();
        int count = 0;
        public Form2()
        {
            InitializeComponent();
            
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
        private void refreshDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var student in list)
            {
                dataGridView1.Rows.Add(student.Id, student.Username, student.Phone);
            }
            txtID.Text = (count + 1).ToString();
            txtUsername.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(txtID.Text.Trim() == string.Empty || txtUsername.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Must fill all the box");
                return;
            }
            if (!txtID.Text.All(char.IsDigit) || !txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Id or Phone must be only number");
                return;
            }
            count++;
            Student student = new Student();
            student.Id = count;
            student.Username = txtUsername.Text;
            student.Phone = txtPhone.Text.Trim();
            list.Add(student);
            refreshDataGridView();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtID.Text = (count + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Must select a row");
                return;
            }
            var result = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Student selectStudent = list.FirstOrDefault(s => s.Id.ToString() == result);
            if (selectStudent != null)
            {
                Form3 form3 = new Form3();
                form3.FillTable(selectStudent);
                form3.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Edit")
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Must select a row");
                    return;
                }
                getID();
                return;
            }

            Student student = list.FirstOrDefault(s => s.Id.ToString() == txtID.Text);
            if (student != null)
            {
                student.Username = txtUsername.Text;
                student.Phone = txtPhone.Text;
                refreshDataGridView();
                button2.Text = "Edit";
                button1.Enabled = true;
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            getID();
        }
        private Student getID()
        {
            var result = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Student selectStudent = list.FirstOrDefault(s => s.Id.ToString() == result);
            txtID.Text = selectStudent.Id.ToString();
            txtUsername.Text = selectStudent.Username;
            txtPhone.Text = selectStudent.Phone;
            button2.Text = "Update";
            button1.Enabled = false;
            return selectStudent;
        }
    }
}

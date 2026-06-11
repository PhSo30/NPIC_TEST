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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        string displayTitle = "TitleKH";
        string level1 = "";
        string level2 = "";
        string level3 = "";
        string level4 = "";
        void changeTitle(string title)
        {
            displayTitle = title;

            int indexComboOne = comboBox1.SelectedIndex;
            int indexComboTwo = comboBox2.SelectedIndex;
            int indexComboThree = comboBox3.SelectedIndex;
            int indexComboFour = comboBox4.SelectedIndex;

            comboBox1.DisplayMember = displayTitle;
            comboBox2.DisplayMember = displayTitle;
            comboBox3.DisplayMember = displayTitle;
            comboBox4.DisplayMember = displayTitle;

            comboBox1.SelectedIndex = indexComboOne;
            comboBox2.SelectedIndex = indexComboTwo;
            comboBox3.SelectedIndex = indexComboThree;
            comboBox4.SelectedIndex = indexComboFour;

            displayTitleInTextBox(1, comboBox1);
            displayTitleInTextBox(2, comboBox2);
            displayTitleInTextBox(3, comboBox3);
            displayTitleInTextBox(4, comboBox4);
        }
        void dataSourceFunction(ComboBox comboBox_1, ComboBox comboBox_2)
        {
            try
            {
                if (comboBox_1.SelectedIndex > -1)
                {
                    int id = (int)comboBox_1.SelectedValue;

                    comboBox_2.DataSource = this.administrativeBoundariesTableAdapter.GetDataByCode(id);
                    if (comboBox_2.DataSource != null)
                    {
                        comboBox_2.DisplayMember = displayTitle;
                        comboBox_2.ValueMember = "ID";
                    }
                }
            }
            catch { }

        }
        void displayTitleInTextBox(int level, ComboBox combo)
        {
            string titleText = combo.Text;

            

            switch (level)
            {
                case 1: level1 = " ["+titleText+"]"; break;
                case 2: level2 = " ["+titleText+"]"; break;
                case 3: level3 = " ["+titleText+"]"; break;
                case 4: level4 = " ["+titleText+"]"; break;

            }
            
            if (displayTitle == "TitleKH")
            {
                textBox2.Text = "រាជធានី/ខេត្ត" + level1 + " |  ស្រុក/ខណ្ឌ" + level2 + " |  ឃុំ/សង្កាត់" + level3 + " |  ភូមិ" + level4;
                
            }
            if (displayTitle == "TitleEN")
            {
                textBox2.Text =  level1 + level2 + level3 + level4;

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            

            comboBox1.DataSource = this.administrativeBoundariesTableAdapter.GetDataByCode(null);
            if(comboBox1.DataSource != null )
            {
                comboBox1.DisplayMember = "TitleKH";
                comboBox1.ValueMember = "ID";
                
            }
            radioButton1.Checked = true;
            
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataSourceFunction(comboBox1, comboBox2);
            displayTitleInTextBox(1, comboBox1);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataSourceFunction(comboBox2, comboBox3);
            displayTitleInTextBox(2, comboBox2);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataSourceFunction(comboBox3, comboBox4);
            displayTitleInTextBox(3, comboBox3);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayTitleInTextBox(4, comboBox4);
        }

        private void administrativeBoundariesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            changeTitle("TitleKH");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            changeTitle("TitleEN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            textBox2.Clear();
        }
    }
}

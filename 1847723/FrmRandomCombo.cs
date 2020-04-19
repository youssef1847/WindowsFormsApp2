using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmRandomCombo : Form
    {
        public FrmRandomCombo()
        {
            InitializeComponent();
        }

        private void FrmRandomCombo_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(comboBox2.Text) > 499)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();      //Resets the Text 
            comboBox2.Items.Clear();    //Removes all items from Combo
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                comboBox2.Items.Add(r.Next(100, 999));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            comboBox2.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            label1.Text = Convert.ToString(comboBox1.Items.Count);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.Text) > 49)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                comboBox1.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(comboBox1.Items.Count);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

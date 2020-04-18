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
    public partial class Frmradio : Form
    {
        public Frmradio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                radioButton1.ForeColor = Color.FromName("Red");
            else
                radioButton1.ForeColor = Color.FromName("Black");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
                radioButton6.ForeColor = Color.FromName("Green");
            else
                radioButton6.ForeColor = Color.FromName("Black");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked==true)
            radioButton5.ForeColor = Color.FromName("Red");
        else
                radioButton5.ForeColor = Color.FromName("Black");
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                radioButton7.ForeColor = Color.FromName("Blue");
            else
                radioButton7.ForeColor = Color.FromName("Black");
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
                radioButton8.ForeColor = Color.FromName("Yellow");
            else
                radioButton8.ForeColor = Color.FromName("Black");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                radioButton2.ForeColor = Color.FromName("Green");
            else
                radioButton2.ForeColor = Color.FromName("Black");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;

            radioButton1.ForeColor = Color.FromName("Black");
            radioButton2.ForeColor = Color.FromName("Black");
            radioButton3.ForeColor = Color.FromName("Black");
            radioButton4.ForeColor = Color.FromName("Black");
            radioButton5.ForeColor = Color.FromName("Black");
            radioButton6.ForeColor = Color.FromName("Black");
            radioButton7.ForeColor = Color.FromName("Black");
            radioButton8.ForeColor = Color.FromName("Black");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                radioButton3.ForeColor = Color.FromName("Blue");
            else
                radioButton3.ForeColor = Color.FromName("Black");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                radioButton4.ForeColor = Color.FromName("Yellow");
            else
                radioButton4.ForeColor = Color.FromName("Black");
        }
    }
}

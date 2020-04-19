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
    public partial class checkbox : Form
    {
        public checkbox()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (checkBox1.Checked == true)
            {

                msg = checkBox1.Text;

            }
            if (checkBox2.Checked == true)
            {

                msg = msg + " " + checkBox2.Text;

            }
            {
            if (checkBox3.Checked == true)

                    msg = msg + " " + checkBox3.Text;

            }

          

            if (msg.Length > 0)
            {
                MessageBox.Show(msg +" "+ "ordered");
            }

          else
            {
                MessageBox.Show("nothing selected");

            }
        }
    }
}

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
    public partial class combo : Form
    {
        public combo()
        {
            InitializeComponent();


            cmbdays.Items.Add("SUNDAY");
            cmbdays.Items.Add("MONDAY");
            cmbdays.Items.Add("TUESDAY");
            cmbdays.Items.Add("WEDNESDAY");
            cmbdays.Items.Add("THURSDAY");
            cmbdays.Items.Add("FRIDAY");
            cmbdays.Items.Add("SATURDAY");
        }

        private void combo_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmbdays.Items.RemoveAt(1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbdays.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbdays.Items.Remove(cmbdays.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbdays.Items.Count >=2)
            {
                cmbdays.Items.RemoveAt(cmbdays.Items.Count - 1);
            }

            else
            {
                MessageBox.Show(" can`t remove last item ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemText = cmbdays.GetItemText(cmbdays.SelectedItem);

            MessageBox.Show(itemText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var item = cmbdays.SelectedItem;
            if (item != null)
                MessageBox.Show(item.ToString());
        }
    }
}

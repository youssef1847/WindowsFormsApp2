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
    public partial class frmMain : Form
    {
        string username = "youssef";
        string myPassword = "1234";

        int attempt = 1;
        int MaxAttempts = 3;

        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frmradio frm = new Frmradio();
            frm.ShowDialog(); 
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (textBox1.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    textBox1.Clear();
                    textBox2.Clear();
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (textBox2.Text != "1234")
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        textBox1.Clear();
                        textBox2.Clear();
                        
                       return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 0; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        button3.Text = "Logout";
                       
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmImage frm = new FrmImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkbox frm = new checkbox();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            combo frm = new combo();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            random frm = new random();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmRandomCombo frm = new FrmRandomCombo();
            frm.ShowDialog();
        }
    }
}

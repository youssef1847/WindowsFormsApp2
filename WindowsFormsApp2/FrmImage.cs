﻿using System;
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
    public partial class FrmImage : Form
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private void PicTry_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("D:\\download.PNG");
        }
    }
}

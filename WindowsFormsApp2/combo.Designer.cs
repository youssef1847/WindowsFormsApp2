﻿namespace WindowsFormsApp2
{
    partial class combo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnShowSelected1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdays = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnShowSelected1
            // 
            this.BtnShowSelected1.Location = new System.Drawing.Point(36, 19);
            this.BtnShowSelected1.Name = "BtnShowSelected1";
            this.BtnShowSelected1.Size = new System.Drawing.Size(140, 62);
            this.BtnShowSelected1.TabIndex = 0;
            this.BtnShowSelected1.Text = "show selected method 1";
            this.BtnShowSelected1.UseVisualStyleBackColor = true;
            this.BtnShowSelected1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "show selected method 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 101);
            this.button3.TabIndex = 2;
            this.button3.Text = "remove last item";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(647, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 94);
            this.button4.TabIndex = 3;
            this.button4.Text = "remove 2nd item";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "Remove by index";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(229, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 63);
            this.button6.TabIndex = 5;
            this.button6.Text = "remove by name";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(647, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 34);
            this.button7.TabIndex = 6;
            this.button7.Text = "back";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "days";
            // 
            // cmbdays
            // 
            this.cmbdays.FormattingEnabled = true;
            this.cmbdays.Location = new System.Drawing.Point(129, 171);
            this.cmbdays.Name = "cmbdays";
            this.cmbdays.Size = new System.Drawing.Size(121, 28);
            this.cmbdays.TabIndex = 8;
            this.cmbdays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "show selected method 3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // combo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnShowSelected1);
            this.Name = "combo";
            this.Text = "combo";
            this.Load += new System.EventHandler(this.combo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSelected1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbdays;
        private System.Windows.Forms.Button button1;
    }
}
namespace WindowsFormsApp2
{
    partial class FrmImage
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
            this.button1 = new System.Windows.Forms.Button();
            this.PicTry = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "load image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(106, 133);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(556, 353);
            this.PicTry.TabIndex = 1;
            this.PicTry.TabStop = false;
            this.PicTry.Click += new System.EventHandler(this.PicTry_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.PicTry);
            this.Controls.Add(this.button1);
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicTry;
    }
}
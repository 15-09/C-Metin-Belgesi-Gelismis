namespace INTmb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rtbTxt = new RichTextBox();
            pctrOf = new PictureBox();
            pctrSf = new PictureBox();
            pctrPr = new PictureBox();
            pictureBox4 = new PictureBox();
            pctrCl = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctrOf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrSf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrPr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrCl).BeginInit();
            SuspendLayout();
            // 
            // rtbTxt
            // 
            rtbTxt.BackColor = Color.White;
            rtbTxt.EnableAutoDragDrop = true;
            rtbTxt.Location = new Point(-2, -2);
            rtbTxt.Name = "rtbTxt";
            rtbTxt.Size = new Size(633, 598);
            rtbTxt.TabIndex = 0;
            rtbTxt.Text = "";
            // 
            // pctrOf
            // 
            pctrOf.BackgroundImage = (Image)resources.GetObject("pctrOf.BackgroundImage");
            pctrOf.BackgroundImageLayout = ImageLayout.Stretch;
            pctrOf.Cursor = Cursors.Hand;
            pctrOf.Location = new Point(637, 12);
            pctrOf.Name = "pctrOf";
            pctrOf.Size = new Size(117, 88);
            pctrOf.TabIndex = 4;
            pctrOf.TabStop = false;
            pctrOf.Click += pictureBox1_Click;
            // 
            // pctrSf
            // 
            pctrSf.BackgroundImage = (Image)resources.GetObject("pctrSf.BackgroundImage");
            pctrSf.BackgroundImageLayout = ImageLayout.Stretch;
            pctrSf.Cursor = Cursors.Hand;
            pctrSf.Location = new Point(637, 121);
            pctrSf.Name = "pctrSf";
            pctrSf.Size = new Size(117, 106);
            pctrSf.TabIndex = 5;
            pctrSf.TabStop = false;
            pctrSf.Click += pictureBox2_Click;
            // 
            // pctrPr
            // 
            pctrPr.BackgroundImage = (Image)resources.GetObject("pctrPr.BackgroundImage");
            pctrPr.BackgroundImageLayout = ImageLayout.Stretch;
            pctrPr.Cursor = Cursors.Hand;
            pctrPr.Location = new Point(637, 250);
            pctrPr.Name = "pctrPr";
            pctrPr.Size = new Size(117, 122);
            pctrPr.TabIndex = 6;
            pctrPr.TabStop = false;
            pctrPr.Click += pctrPr_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(637, 521);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 68);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pctrCl
            // 
            pctrCl.BackgroundImage = (Image)resources.GetObject("pctrCl.BackgroundImage");
            pctrCl.BackgroundImageLayout = ImageLayout.Stretch;
            pctrCl.Cursor = Cursors.Hand;
            pctrCl.Location = new Point(637, 394);
            pctrCl.Name = "pctrCl";
            pctrCl.Size = new Size(117, 112);
            pctrCl.TabIndex = 8;
            pctrCl.TabStop = false;
            pctrCl.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(766, 604);
            Controls.Add(pctrCl);
            Controls.Add(pictureBox4);
            Controls.Add(pctrPr);
            Controls.Add(pctrSf);
            Controls.Add(pctrOf);
            Controls.Add(rtbTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pctrOf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrSf).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrPr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrCl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbTxt;
        private PictureBox pctrOf;
        private PictureBox pctrSf;
        private PictureBox pctrPr;
        private PictureBox pictureBox4;
        private PictureBox pctrCl;
    }
}

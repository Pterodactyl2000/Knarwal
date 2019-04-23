namespace Maze
{
    partial class Title
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonclosetop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Maze.Properties.Resources.Knarltitle;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.Transparent;
            this.buttonstart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonstart.ForeColor = System.Drawing.Color.Maroon;
            this.buttonstart.Location = new System.Drawing.Point(74, 354);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 1;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonclosetop
            // 
            this.buttonclosetop.BackColor = System.Drawing.Color.Transparent;
            this.buttonclosetop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonclosetop.ForeColor = System.Drawing.Color.Maroon;
            this.buttonclosetop.Location = new System.Drawing.Point(173, 354);
            this.buttonclosetop.Name = "buttonclosetop";
            this.buttonclosetop.Size = new System.Drawing.Size(75, 23);
            this.buttonclosetop.TabIndex = 2;
            this.buttonclosetop.Text = "Close";
            this.buttonclosetop.UseVisualStyleBackColor = false;
            this.buttonclosetop.Click += new System.EventHandler(this.buttonclosetop_Click);
            // 
            // Title
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonclosetop);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Title";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.Title_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button buttonstart;
        public System.Windows.Forms.Button buttonclosetop;
    }
}
namespace Maze
{
    partial class Maze
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
            this.Narwhal = new System.Windows.Forms.PictureBox();
            this.display = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.Wall4 = new System.Windows.Forms.PictureBox();
            this.wall5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Narwhal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).BeginInit();
            this.SuspendLayout();
            // 
            // Narwhal
            // 
            this.Narwhal.Image = global::Maze.Properties.Resources.Narwhal1;
            this.Narwhal.Location = new System.Drawing.Point(12, 12);
            this.Narwhal.Name = "Narwhal";
            this.Narwhal.Size = new System.Drawing.Size(41, 19);
            this.Narwhal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Narwhal.TabIndex = 20;
            this.Narwhal.TabStop = false;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Blue;
            this.display.Location = new System.Drawing.Point(493, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(258, 449);
            this.display.TabIndex = 14;
            this.display.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Maroon;
            this.wall1.Location = new System.Drawing.Point(59, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(26, 399);
            this.wall1.TabIndex = 21;
            this.wall1.TabStop = false;
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Maroon;
            this.Wall2.Location = new System.Drawing.Point(137, 50);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(26, 399);
            this.Wall2.TabIndex = 22;
            this.Wall2.TabStop = false;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Maroon;
            this.wall3.Location = new System.Drawing.Point(219, 50);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(203, 26);
            this.wall3.TabIndex = 23;
            this.wall3.TabStop = false;
            // 
            // Wall4
            // 
            this.Wall4.BackColor = System.Drawing.Color.Maroon;
            this.Wall4.Location = new System.Drawing.Point(476, 0);
            this.Wall4.Name = "Wall4";
            this.Wall4.Size = new System.Drawing.Size(26, 449);
            this.Wall4.TabIndex = 24;
            this.Wall4.TabStop = false;
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.Maroon;
            this.wall5.Location = new System.Drawing.Point(219, 115);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(26, 284);
            this.wall5.TabIndex = 25;
            this.wall5.TabStop = false;
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.Wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.Narwhal);
            this.Controls.Add(this.display);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Maze";
            this.Text = "Maze";
            this.Load += new System.EventHandler(this.Maze_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.swim);
            ((System.ComponentModel.ISupportInitialize)(this.Narwhal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox display;
        private System.Windows.Forms.PictureBox Narwhal;
        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox Wall2;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox Wall4;
        private System.Windows.Forms.PictureBox wall5;
    }
}


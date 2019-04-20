using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Maze
{
    public partial class Maze : Form
    {
        
        public Maze()
        {
            InitializeComponent();        
        }

        private void Maze_Load(object sender, EventArgs e)
        { }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Buttonleft_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left -= 5;
            Narwhal.Image = Properties.Resources.Narwhal2;
            
        }

        public void buttonright_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left += 5;
            Narwhal.Image = Properties.Resources.Narwhal1;
        }

        public void buttonup_Click(object sender, EventArgs e)
        {
            
            Collision();
            Narwhal.Top -= 5;
            Narwhal.Image = Properties.Resources.Narwhal3;
        }

        public void buttondown_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Top += 5;
           Narwhal.Image = Properties.Resources.Narwhal4;
            
        }
    void Collision()
    {

        if ((wall1.Bounds).IntersectsWith(Narwhal.Bounds))
        {
            crash();
        }
        else if ((Wall2.Bounds).IntersectsWith(Narwhal.Bounds))
        {
            crash();
        }
        else if ((wall3.Bounds).IntersectsWith(Narwhal.Bounds))
        {
            crash();
        }
        else if ((Wall4.Bounds).IntersectsWith(Narwhal.Bounds))
        {
            crash();
        }
        else if ((wall5.Bounds).IntersectsWith(Narwhal.Bounds))
        {
            crash();
        }
            else if ((wall6.Bounds).IntersectsWith(Narwhal.Bounds))
            {
                crash();
            }
            else if ((wall7.Bounds).IntersectsWith(Narwhal.Bounds))
            {
                crash();
            }
            else if ((wall8.Bounds).IntersectsWith(Narwhal.Bounds))
            {
                crash();
            }
            else if ((wall9.Bounds).IntersectsWith(Narwhal.Bounds))
            {
                crash();
            }
            else if ((wall10.Bounds).IntersectsWith(Narwhal.Bounds))
            {
                crash();
            }




        }
        void crash()
        {
            Narwhal.Left = 47;
            Narwhal.Top = 41;
            MessageBox.Show("Oh No!  You crashed, try again.");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"Properties.Resources.Narwhal_Song";
            axWindowsMediaPlayer1.settings.setMode("repeat", true);
            
        }
    }
    
}

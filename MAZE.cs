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

//            SoundPlayer whal = new SoundPlayer(Properties.Resources.Narwals_song);
  //          whal.Play();
            
         
        }

        private void Maze_Load(object sender, EventArgs e)
        { }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Image currentNarwhalImage = Properties.Resources.Narwhal2;

        public void Buttonleft_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left -= 5;
            currentNarwhalImage = Properties.Resources.Narwhal2;
            
        }

        public void buttonright_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left += 5;
            currentNarwhalImage = Properties.Resources.Narwhal1;
        }

        public void buttonup_Click(object sender, EventArgs e)
        {
            
            Collision();
            Narwhal.Top -= 5;
            currentNarwhalImage = Properties.Resources.Narwhal3;
        }

        public void buttondown_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Top += 5;
           currentNarwhalImage = Properties.Resources.Narwhal4;
            
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




    }
        void crash()
        {
            Narwhal.Left = 47;
            Narwhal.Top = 41;
            MessageBox.Show("Oh No!  You crashed, try again.");
        }
    }
    
}

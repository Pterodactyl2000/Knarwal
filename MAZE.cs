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

        public void Maze_Load(object sender, EventArgs e)
        {
            which();
        }

        public void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Buttonleft_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left -= 5;
            Narwhal.Image = Properties.Resources.Narwhal2;
            eat();

        }

        public void buttonright_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Left += 5;
            Narwhal.Image = Properties.Resources.Narwhal1;
            eat();
        }

        public void buttonup_Click(object sender, EventArgs e)
        {

            Collision();
            Narwhal.Top -= 5;
            Narwhal.Image = Properties.Resources.Narwhal3;
            eat();
        }

        public void buttondown_Click(object sender, EventArgs e)
        {
            Collision();
            Narwhal.Top += 5;
            Narwhal.Image = Properties.Resources.Narwhal4;
            eat();

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


        }
        
        void eat()
        {
            if ((Narwhal.Bounds).IntersectsWith(fish8.Bounds))
            {
                fish8.Image = Properties.Resources.hide;
                which();
            }
            else if((Narwhal.Bounds).IntersectsWith(fish7.Bounds))
            {
                fish7.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish6.Bounds))
            {
                fish6.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish5.Bounds))
            {
                fish5.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish4.Bounds))
            {
                fish4.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish3.Bounds))
            {
                fish3.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish2.Bounds))
            {
                fish2.Image = Properties.Resources.hide;
                which();
            }
            else if ((Narwhal.Bounds).IntersectsWith(fish1.Bounds))
            {
                fish1.Image = Properties.Resources.hide;
                which();
            }
        }
    public void fish4_Click(object sender, EventArgs e)
        {
            
        }

        public void fish2_Click(object sender, EventArgs e)
        {
           
        }

        public void fish8_Click(object sender, EventArgs e)
        {
           
        }

         void which()
        {
            
            int e;
            Random thing = new Random();
            e = thing.Next(8);

            switch(e)
            {
                case 0:
                    {
                        fish1.Image = Properties.Resources.FSH;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 1:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.FSH;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 2:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.FSH;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 3:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.FSH;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 4:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.FSH;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 5:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.FSH;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 6:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.FSH;
                        fish8.Image = Properties.Resources.hide;
                        break;
                    }
                case 7:
                    {
                        fish1.Image = Properties.Resources.hide;
                        fish2.Image = Properties.Resources.hide;
                        fish3.Image = Properties.Resources.hide;
                        fish4.Image = Properties.Resources.hide;
                        fish5.Image = Properties.Resources.hide;
                        fish6.Image = Properties.Resources.hide;
                        fish7.Image = Properties.Resources.hide;
                        fish8.Image = Properties.Resources.FSH;
                        break;
                    }
            }
        }
    }
}



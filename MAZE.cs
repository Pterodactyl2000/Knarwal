using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();
            //SoundPlayer soundplayer = new SoundPlayer();
           // soundplayer.PlayLooping();
        }

        private void Maze_Load(object sender, EventArgs e)
        {

        }


        public void swim(object sender, KeyEventArgs e)
        {


            switch (e.KeyCode)
            {
                case Keys.Left:
                    collision();
                    Narwhal.Left -= 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal2.gif");
                    break;
                case Keys.Right:
                    collision();
                    Narwhal.Left += 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal.gif");
                    break;
                case Keys.Up:
                    collision();
                    Narwhal.Top -= 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal3.gif");
                    break;
                case Keys.Down:
                    collision();
                    Narwhal.Top += 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal4.gif");
                    break;
            }

            void collision()
            {

                if ((wall1.Bounds).IntersectsWith(Narwhal.Bounds))
                {
                    Narwhal.Left = 0;
                    Narwhal.Top = 0;
                    MessageBox.Show("Oh No!  You crashed, try again.");
                }
                else if((Wall2.Bounds).IntersectsWith(Narwhal.Bounds))
                {
                    Narwhal.Left = 0;
                    Narwhal.Top = 0;
                    MessageBox.Show("Oh No!  You crashed, try again.");
                }
                else if ((wall3.Bounds).IntersectsWith(Narwhal.Bounds))
                {
                    Narwhal.Left = 0;
                    Narwhal.Top = 0;
                    MessageBox.Show("Oh No!  You crashed, try again.");
                }
                else if((Wall4.Bounds).IntersectsWith(Narwhal.Bounds))
                {
                    Narwhal.Left = 0;
                    Narwhal.Top = 0;
                    MessageBox.Show("Oh No!  You crashed, try again.");
                }
                else if((wall5.Bounds).IntersectsWith(Narwhal.Bounds))
                {
                    Narwhal.Left = 0;
                    Narwhal.Top = 0;
                    MessageBox.Show("Oh No!  You crashed, try again.");
                }




            }

            
           
        }
            
        
    }
}

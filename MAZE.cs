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

namespace Maze
{
    public partial class Maze : Form
    {
        public Maze()
        {
            InitializeComponent();

            var pic = Properties.Resources.Narwhal2;


            using (var soundplayer = new SoundPlayer(Properties.Resources.Narwals_song))
            {
                soundplayer.PlayLooping();
            }
        }

        private void Maze_Load(object sender, EventArgs e)
        {

        }


        public void swim(object sender, KeyEventArgs e)
        {
            Image currentNarwhalImage = Narwhal.Image;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    collision();
                    Narwhal.Left -= 5;
                    currentNarwhalImage = Properties.Resources.Narwhal2;
                    Narwhal.Image = currentNarwhalImage;
                    break;
                case Keys.Right:
                    collision();
                    Narwhal.Left += 5;
                    currentNarwhalImage = Properties.Resources.Narwhal;
                    Narwhal.Image = currentNarwhalImage;
                    break;
                case Keys.Up:
                    collision();
                    Narwhal.Top -= 5;
                    currentNarwhalImage = Properties.Resources.Narwhal3;
                    Narwhal.Image = currentNarwhalImage;
                    break;
                case Keys.Down:
                    collision();
                    Narwhal.Top += 5;
                    currentNarwhalImage = Properties.Resources.Narwhal4;
                    Narwhal.Image = currentNarwhalImage;
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

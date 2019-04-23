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
        int scorecard = 0000;
        int lives = 3;


        public Maze()
        {
            InitializeComponent();

        }



        public void Maze_Load(object sender, EventArgs e)
        {
            scorelabel.Text = scorecard.ToString();
            lifecount.Text = lives.ToString();
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
                lives = lives - 1;
            lifecount.Text = lives.ToString();
            if (lives > 0)

                MessageBox.Show("Oh No!  You died!");
            else if(lives == 0)
                    {
                
                MessageBox.Show("GAME OVER");
                this.Close();
                Title x = new Title();
                x.ShowDialog();

                
            }
                  
                
            }

            private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
            {
                axWindowsMediaPlayer1.URL = @"Properties.Resources.Narwhal_Song";


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










            public void scorelabel_Click(object sender, EventArgs e)
            {
                scorelabel.Text = scorecard.ToString();
            }

            public void lifecount_Click(object sender, EventArgs e)
            {
                lifecount.Text = lives.ToString();
            }
        }
    }




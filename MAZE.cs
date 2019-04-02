using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void Maze_Load(object sender, EventArgs e)
        {

        }
       

        public void swim(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Narwhal.Left -= 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal2.gif");
                    break;
                case Keys.Right:
                    Narwhal.Left += 5;                  
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal.gif");
                    break;
                case Keys.Up:
                    Narwhal.Top -= 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal3.gif");
                    break;
                case Keys.Down:
                    Narwhal.Top += 5;
                    Narwhal.Image = Image.FromFile("C:/Users/MSSA/Source/Repos/Maze/Properties/Narwhal4.gif");
                    break;
            }
        }
    }
}

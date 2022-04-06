using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmojiPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Emoji emoji = new SmileyFace(new Point(225, 225), new Point(25, 25), Color.Yellow);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(Color.White);
            emoji.Draw(g);
            
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            emoji.BackColor = Color.Blue;
        }

        private void buttonGray_Click(object sender, EventArgs e)
        {
            emoji.BackColor = Color.Gray;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            emoji.BackColor = Color.Green;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Random randtemp = new Random();
            int value = randtemp.Next(1, 4); 

            switch (value)
            {
                case 1: 
                    emoji = new SmileyFace(new Point(emoji.Center.X, emoji.Center.Y), new Point(25,25), Color.Yellow);
                    break;
                case 2:
                    emoji = new NeutralFace(new Point(emoji.Center.X, emoji.Center.Y), new Point(25, 25), Color.Orange);
                    break;
                case 3:
                    emoji = new SadFace(new Point(emoji.Center.X, emoji.Center.Y), new Point(25, 25), Color.Tomato);
                    break;
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            
            emoji.Move(0, - emoji.Velocity.Y);

        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            emoji.Move(0, emoji.Velocity.Y);

        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            emoji.Move(- emoji.Velocity.X, 0);

        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            emoji.Move(emoji.Velocity.X, 0);

        }


    }
}

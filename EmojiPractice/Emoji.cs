using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmojiPractice
{
    internal class Emoji:Sprite
    {
        private int radius = 75;

        public Emoji(Point center, Point velocity, Color color) : base(center, velocity, color)
        {
        }

        public Rectangle GetBounds() 
        {

            return new Rectangle(Center.X - 75, Center.Y - 75, 150,150);
        }

        public override void Draw(Graphics g)
        {
            Rectangle bounds = GetBounds();
            
            Pen myPen = new Pen(Color.Black, 3);
            g.DrawEllipse(myPen, bounds);

            SolidBrush myBrush = new SolidBrush(base.BackColor);
            g.FillEllipse(myBrush, bounds);

            SolidBrush eyeBrush = new SolidBrush(Color.Black);
            g.FillEllipse(eyeBrush, new Rectangle(base.Center.X + 20, base.Center.Y - 45, 20, 40));
            g.FillEllipse(eyeBrush, new Rectangle(base.Center.X - 40, base.Center.Y - 45, 20, 40));
        }

        public override void Move(int MaxX, int MaxY)
        {
            Center.X += MaxX;
            Center.Y += MaxY;

            if(Center.X < radius || Center.Y < radius || Center.X >  radius*5 || Center.Y > radius*5)
            {
                Center.X = 225;
                Center.Y = 225;
            }
            else
            {
                Center.X += MaxX;
                Center.Y += MaxY;
            }
        }
    }
}

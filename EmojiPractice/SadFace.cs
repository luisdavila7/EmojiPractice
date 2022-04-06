using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmojiPractice
{
    internal class SadFace:Emoji
    {
        public SadFace(Point center, Point velocity, Color color) : base(center, velocity, color)
        {
            Center = center;
            Velocity = velocity;
            BackColor = Color.Tomato;
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

            g.DrawArc(myPen, new Rectangle(Center.X - 30, Center.Y + 25, 60, 50),0 , -180);
        }
    }
}

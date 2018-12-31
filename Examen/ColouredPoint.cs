using System;
using System.Drawing;
namespace Examen
{
    public class ColouredPoint : Point//,Drawable
    {
        private readonly String colour;

        public ColouredPoint(int x, int y, String colour) : base(x, y)
        {
            this.colour = colour;
        }

        public String Colour { get { return colour; } }

        //public void Draw(Graphics g)
        //{
        //    g.DrawEllipse(new Pen(colour), X, Y, 3, 3);
        //}

        public override Point Translate(int dx, int dy)
        {
            return new ColouredPoint(X + dx, Y + dy, colour);
        }

        public override string ToString()
        {
            return String.Format(" {0} [ String ={1}] ", base.ToString(), colour);
        }
    }
}

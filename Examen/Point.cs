using System;
using System.Drawing;
namespace Examen
{
    public class Point
    {
        private readonly int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public virtual Point Translate(int dx, int dy)
        {
            return new Point(x + dx, y + dy);
        }

        public override string ToString()
        {
            return String.Format("({0} , {1}) ", x, y);
        }
    }
}

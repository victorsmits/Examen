using System;
namespace Examen
{
    public class IntPair
    {
        private readonly int x, y;

        // [...]

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            IntPair p = (IntPair)obj;
            return x == p.x && y == p.y;
        }

        public override string ToString()
        {
            return String.Format("({0} , {1}) ", x, y);
        }
    }
}

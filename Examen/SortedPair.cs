using System;
namespace Examen
{
    public class SortedPair
    {
        private int x, y;

        public SortedPair(int x, int y)
        {
            this.x = x < y ? x : y;
            this.y = y > x ? y : x;
        }

        public int X
        {
            set
            {
                if (value < y) // Vérification encapsulée
                {
                    this.x = value; // dans un setter de la classe
                }
            }
        }
    }
}

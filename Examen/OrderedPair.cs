using System;
namespace Examen
{
    public class OrderedPair<T> where T : IComparable
    {
        private readonly T min, max;

        public OrderedPair(T a, T b)
        {
            bool comp = a.CompareTo(b) > 0;
            min = comp ? b : a;
            max = comp ? a : b;
        }

        public override string ToString()
        {
            return String.Format("({0} , {1}) ", min, max);
        }
    }
}

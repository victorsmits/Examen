using System;
namespace Examen
{
    public class Pair<S, T>
    {
        private readonly S first;
        private readonly T second;

        public Pair(S first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public S First { get { return first; } }
        public T Second { get { return second; } }

        public override string ToString()
        {
            return String.Format("({0} , {1}) ", first, second);
        }

    }
}

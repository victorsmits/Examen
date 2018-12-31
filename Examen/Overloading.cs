using System;
namespace Examen
{
    public class Overloading
    {
        public int Test(int a, int b)
        {
            Console.Write("I ");
            return a + b;
        }

        public string Test(long a, char b)
        {
            Console.Write("S ");
            return "" + a + b;
        }

        public double Test(byte a, int b)
        {
            Console.Write("D ");
            return a + b;
        }

        public char Test(long a, short b)
        {
            Console.Write("C ");
            return (char)(a + b);

        }
    }
}

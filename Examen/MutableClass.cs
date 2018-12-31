using System;
namespace Examen
{
    public class MutableClass
    {
        public readonly int[] secrets;

        public MutableClass(int x, int y)
        {
            secrets = new int[] { x, y };
        }
    }
}

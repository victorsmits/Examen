using System;
namespace Examen
{
    public class Container<T>
    {
        public readonly T data;

        public Container()
        {
            data = default(T);
        }
    }
}

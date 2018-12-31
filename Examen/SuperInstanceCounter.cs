using System;
namespace Examen
{
    public class SuperInstanceCounter : InstanceCounter
    {
        public SuperInstanceCounter()
        {
            Console.WriteLine("Je suis la " + Counter + "e instance .");
        }
    }
}

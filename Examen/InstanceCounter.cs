using System;
namespace Examen
{
	public class InstanceCounter
	{
		private static int counter = 0;

		public static int Counter {
			get { return counter; }
		}

		public InstanceCounter()    // constructeur
		{
			counter++;
		}
	}
}

using System;
namespace Examen
{
	public class Outer
	{
		private String name = " Outer ";

		public class Inner
		{
			private readonly Outer o;
			private String name = " Inner ";

			public Inner(Outer o)
			{
				this.o = o;
			}

			public override string ToString()
			{
				return String.Format(" {0}: {1} ", this.name, o.name);
			}
		}
	}
}

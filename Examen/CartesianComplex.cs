using System;
namespace Examen
{
	public class CartesianComplex : Complex
	{
		private readonly double a, b;

		// a + bi
		public CartesianComplex(double a, double b)
		{
			this.a = a;
			this.b = b;
		}

		public double Real() { return a; }
		public double Imag() { return b; }
		public double Abs() { return Math.Sqrt(a * a + b * b); }
		public double Arg() { return Math.Acos(a / Abs()); }
		public override string ToString() { return a + "+" + b + "i"; }
	}
}

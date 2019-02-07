using System;
namespace Examen
{
	public class PolarComplex : Complex
	{
		private readonly double r, theta;

		public PolarComplex(double r, double theta)
		{
			this.r = r;
			this.theta = theta;
		}

		public double Real() { return r * Math.Cos(theta); }
		public double Imag() { return r * Math.Sin(theta); }
		public double Abs() { return r; }
		public double Arg() { return theta; }
		public override string ToString() { return r + "e^j" + theta; }
	}
}

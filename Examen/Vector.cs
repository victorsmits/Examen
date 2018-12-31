using System;
namespace Examen
{
    public class Vector
    {
        private double[] coords;

        public Vector(double[] coords)
        {
            this.coords = new double[coords.Length];
            Array.Copy(coords, this.coords, coords.Length);
        }

        public double[] Coords
        {
            get
            {
                double[] coords = new double[this.coords.Length];
                Array.Copy(this.coords, coords, this.coords.Length);
                return coords;
            }
        }

        public override string ToString()
        {
            return string.Format(" ({0}) ", String.Join(", ", Array.ConvertAll(
           coords, Convert.ToString)));
        }
    }
}

using System;
namespace Examen
{
    public class Utils
    {
        private static readonly int TAX_RATE = 21;

        private Utils()
        {
        }

        public static double GetTaxIncPrice(double price)
        {
            return price * (1 + TAX_RATE / 100.0);
        }
    }
}

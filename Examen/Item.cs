using System;
namespace Examen
{
    public class Item
    {
        private readonly string barcode;
        private readonly string name;
        private readonly double price;

        public Item(string barcode, string name, double price)
        {
            this.barcode = barcode;
            this.name = name;
            this.price = price;
        }

        public double GetPrice(int quantity)
        {
            return quantity * price;
        }

        public static Item ParseItem(string line)
        {
            String[] tokens = line.Split(';');
            return new Item(tokens[0], tokens[1], Convert.ToDouble(tokens[2]));
        }
    }
}

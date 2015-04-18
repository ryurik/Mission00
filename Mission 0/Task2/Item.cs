using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Item
    {
        public string Name { get; set; }
        public double Price{ get; set; }
        public int Quantity {get ; set; }

        public double WholeCost()
        {
            return Price * Quantity;
        }

        public Item()
        {
            Random rnd = new Random();
            Name = _names[rnd.Next(_names.Count())];
            Price = rnd.NextDouble() * 1000; // считаем стоимость товара до 1000 уе
            Quantity = rnd.Next(1000);
        }
    }

    public struct ItemStruct
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double WholeCost()
        {
            return Price * Quantity;
        }

        public ItemStruct(string Name, double Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        
    }
}

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

        public ItemStruct(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        
    }
}

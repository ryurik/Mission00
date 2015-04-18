using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Item
    {
        private string[] _names = {"Книги",};
         
        private string _name;
        private float _price;
        private int _quantity;

        public string Name
        {
            get { return this._name; } 
            set { this._name = value; }
        }
        public float Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public int Quantity {
            get {return this._quantity;}
            set { this.Quantity = _quantity; }
        }
        public float WholeCost()
        {
            return this.Price*this.Quantity;
        }
    }
}

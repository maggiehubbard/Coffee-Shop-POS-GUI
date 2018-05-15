using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Drink : Product
    {
        private int size;
        private string temp;

        public string Temp { get => temp; set => temp = value; }
        public int Size { get => size; set => size = value; }

        public Drink(string name, double price, string categ, string descrip, string temp, int size)
        {
            this.Name = name;
            this.Price = price;
            this.Categ = categ;
            this.Descrip = descrip;
            this.temp = temp;
            this.size = size;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}

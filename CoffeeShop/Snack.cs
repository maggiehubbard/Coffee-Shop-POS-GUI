using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Snack : Product
    {
        private string taste;

        public string Taste { get => taste; set => taste = value; }

        public Snack(string name, double price, string categ, string descrip, string taste)
        {
            this.Name = name;
            this.Price = price;
            this.Categ = categ;
            this.Descrip = descrip;
            this.Taste = taste;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }

    }
}

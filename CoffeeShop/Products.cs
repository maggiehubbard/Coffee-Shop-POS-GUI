using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    abstract class Product
    {
        private string name;
        private double price;
        private string categ;
        private string descrip;
        

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Categ { get => categ; set => categ = value; }
        public string Descrip { get => descrip; set => descrip = value; }
    
    }
}

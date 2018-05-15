using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CoffeeShop
{
    public class ReusableCode
    {


        public static ArrayList ShoppingCart = new ArrayList();


        public static ArrayList PriceCart = new ArrayList();

        public static ArrayList QuantityList = new ArrayList();

        public static double CalcSub()
        {
            double subT = 0;
            for (int i = 0; i < PriceCart.Count; i++)
            {
                subT += (double)(PriceCart[i]);
            }
            return subT;
        }

        public static double CalcTax()
        {
            return CalcSub() * 0.06;
        }

        public static double CalcGT()
        {
            return CalcSub() + CalcTax();
        }

        public static double amtTendered;
        public static string pword = "m";
        
    }

}


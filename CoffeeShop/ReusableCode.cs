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


        public static ArrayList ShoppingCart = new ArrayList(); //creates users shoppig list


        public static ArrayList PriceCart = new ArrayList(); //hold price field of products items to be added together @ checkout

        public static ArrayList QuantityList = new ArrayList(); //usedx to hold the comments of item added to the cart

        public static double CalcSub() //this method calulates the subtotal of the shopping cart
        {
            double subT = 0;
            for (int i = 0; i < PriceCart.Count; i++)
            {
                subT += (double)(PriceCart[i]);
            }
            return subT;
        }

        public static double CalcTax() //calculates tax on the subtotal
        {
            return CalcSub() * 0.06;
        }

        public static double CalcGT() //adds tax to the subtotal
        {
            return CalcSub() + CalcTax();
        }

        public static double amtTendered; //saves the amount cutomer tendered when paying with cash
        public static string pword = "m"; //password for user admin to add to inventory
        
    }

}


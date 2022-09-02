using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Register
{
    public class CashRegister
    {
        // One function: Takes a list of products
        // and calculates the grand total price.
        public static decimal GrandTotal(List<Product> prods)
        {
            decimal total = 0.0m;
            foreach(Product prod in prods)
            {
                total += prod.Price;
            }
            return total;
        }

        // Second function: Takes a list of products
        // and calculates the sales tax. (say 6%)

        public static decimal CalulateTax(List<Product> prods)
        {
            //You'll need to total the price and
            //then calulate the tax.
            // So for example if we have a list like this:
            //      milk, 2.00
            //      bread, 2.50
            //      CokeZero, 2.50
            // Return 0.42
            decimal total = GrandTotal(prods);
            decimal taxTotal = total * .06m;
            return taxTotal;
        }

        public static string FinalTotal(List<Product> prods)
        {
            decimal subtotal = CashRegister.GrandTotal(prods);
            decimal taxtotal = CashRegister.CalulateTax(prods);
            decimal finaltotal = subtotal + taxtotal;
            string converted = finaltotal.ToString("0.00");
            return converted;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace GenericItem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> shoppingCart = new List<LineItem>();
            shoppingCart.Add(new LineItem(101, "Cooking Oil", 2, 100));
            shoppingCart.Add(new LineItem(102, "Packaged Food", 10, 35));
            shoppingCart.Add(new LineItem(103, "Biscuits", 5, 30));

            foreach (object cartitem in shoppingCart)
            {
                LineItem item = (LineItem)cartitem;
                PrintInfo(item);
            }
            Console.ReadLine();
        }

        public static void PrintInfo(LineItem lineItem)
        {
            Console.WriteLine("Id:" + lineItem.Id);
            Console.WriteLine("ProductName:" + lineItem.ProductName);
            Console.WriteLine("Quantity:" + lineItem.Quantity);
            Console.WriteLine("Price:" + lineItem.Price);
            lineItem.CalculateTotal();
            Console.WriteLine("Total Amt.:" + lineItem.FinalTotal);
            Console.WriteLine();
        }
    }
}


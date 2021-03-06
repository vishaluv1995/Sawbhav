using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LineItem
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList shoppingCart = new ArrayList();
            shoppingCart.Add(new LineItemN(101, "book", 2, 100));
            shoppingCart.Add(new LineItemN(102, "wheat", 10, 35));
            shoppingCart.Add(new LineItemN(103, "pencil", 5, 30));
            shoppingCart.Add(100);
            shoppingCart.Add("hello");

            foreach (object cartitem in shoppingCart)
            {
                Type type = cartitem.GetType();
                if (type.Name == "LineItemN")
                {
                    LineItemN item = (LineItemN)cartitem;
                    PrintInfo(item);
                }
            }
            Console.ReadLine();
        }

        public static void PrintInfo(LineItemN lineItem)
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

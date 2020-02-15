using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer firstcustomer = new Customer("Harshada", "Sagvekar");
            Customer secondcustomer = new Customer("Ashish", "Salvi");
            Customer thirdcustomer = new Customer("Kishor", "Kambhale");

            Console.WriteLine(firstcustomer.CustprefixWithId);
            Console.WriteLine(secondcustomer.CustprefixWithId);
            Console.WriteLine(thirdcustomer.CustprefixWithId);
            Console.ReadLine();
        }

    }
}

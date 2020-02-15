using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account objaccount = new Account("Kishore", "A1234", 500);
            Console.WriteLine("Before Deposite Info");
            PrintInfo(objaccount);

            Console.WriteLine("After Deposite Info");
            objaccount.DepositeAmt(500);
            PrintInfo(objaccount);

            Console.WriteLine("Before Withrawal Info");
            PrintInfo(objaccount);

            Console.WriteLine("After Withrawal Info");
            objaccount.WithrawAmt(500);
            PrintInfo(objaccount);


            Account objaccount2 = new Account("Ashish", "A5678", 500);
            Console.WriteLine("Before Deposite Info");
            PrintInfo(objaccount2);

            Console.WriteLine("After Deposite Info");
            objaccount2.DepositeAmt(500);
            PrintInfo(objaccount2);

            Console.ReadLine();
        }

        public static void PrintInfo(Account objaccount)
        {
            Console.WriteLine("Custmer Name:" + objaccount.CustName);
            Console.WriteLine("A/c No.:" + objaccount.AcNo);
            Console.WriteLine("Balance Amt:" + objaccount.BalAmt);
            Console.WriteLine("Number of transaction:" + objaccount.NumberOfTransCount);
            Console.WriteLine("");
        }
    }
}

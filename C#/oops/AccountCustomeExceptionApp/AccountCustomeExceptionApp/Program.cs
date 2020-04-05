using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomeExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Kishore", "1234", 1000);
            PrintDetails(account);

            Console.WriteLine("Before Deposite Info");
            account.DepositeAmt(1000);

            Console.WriteLine("");

            Console.WriteLine("After Deposite Info");
            PrintDetails(account);

            Console.WriteLine("Withdraw Amt");

            try
            {
                account.WithrawAmt(600000);
                PrintDetails(account);
            }
            catch (InsufficentFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Name: " + account.CustName);
            Console.WriteLine("Account Number: " + account.AcNo);
            Console.WriteLine("Balance Amount: " + account.BalAmt);
            Console.WriteLine("");
        }

    }
}

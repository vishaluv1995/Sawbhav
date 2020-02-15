using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();

            PrintInfo(new SavingAccount(7676,"Aswini",500d));
            PrintInfo(new CurrentAccount(7676, "Aswini", 500d));
            Console.Read();
        }

        private static void Case2()
        {
            CurrentAccount curaccount = new CurrentAccount(5678, "Mayuresh", 100);
            Console.WriteLine(curaccount.GetName);
            Console.WriteLine(curaccount.GetAccountNo);
            Console.WriteLine(curaccount.GetBalance);

            Console.WriteLine("Before Deposite");
            Console.WriteLine(curaccount.GetBalance);

            Console.WriteLine("After Deposite");
            curaccount.Deposite(500);
            Console.WriteLine(curaccount.GetBalance);

            Console.WriteLine("Before Withdraw");
            Console.WriteLine(curaccount.GetBalance);

            Console.WriteLine("After Withdraw");
            curaccount.Withdraw(6000);
        }

        private static void Case1()
        {
            SavingAccount saving = new SavingAccount(1234, "Dipesh", 500d);
            Console.WriteLine(saving.GetName);
            Console.WriteLine(saving.GetAccountNo);
            Console.WriteLine(saving.GetBalance);

            Console.WriteLine("Before Deposite");
            Console.WriteLine(saving.GetBalance);

            Console.WriteLine("After Deposite");
            saving.Deposite(500);
            Console.WriteLine(saving.GetBalance);

            Console.WriteLine("Before Withdraw");
            Console.WriteLine(saving.GetBalance);

            Console.WriteLine("After Withdraw");
            saving.Withdraw(600);
        }

        public static void PrintInfo(Account account)
        {
            Console.WriteLine(account.GetType());
            Console.WriteLine(account.GetHashCode());
        }
    }
}

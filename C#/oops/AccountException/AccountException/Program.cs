using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case1();

            Case2();

            Console.WriteLine("End of Program");
            Console.ReadLine();
        }

        private static void Case2()
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
                account.WithrawAmt(6000);
                PrintDetails(account);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Log(ex.StackTrace);
            }
        }

        private static void Case1()
        {
            Account account = new Account("Kishore", "1234", 1000);
            PrintDetails(account);

            Console.WriteLine("Before Deposite Info");
            account.DepositeAmt(1000);

            Console.WriteLine("");

            Console.WriteLine("After Deposite Info");
            PrintDetails(account);

            Console.WriteLine("Withdraw Amt");
            account.WithrawAmt(6000);

            PrintDetails(account);
        }

        public static void PrintDetails(Account account)
        {
            Console.WriteLine("Name: " + account.CustName);
            Console.WriteLine("Account Number: " + account.AcNo);
            Console.WriteLine("Balance Amount: " + account.BalAmt);
            Console.WriteLine("");
        }

        public static void Log(string err)
        {
            string strfilepath = @"C:\\ErrLog\\log.txt";

            if (File.Exists(strfilepath))
            {
                StringBuilder sb = new StringBuilder();
                StreamWriter sw;

                sb.Clear();
                sb.Append(File.ReadAllText(strfilepath));
                sb.Append(err);
                sw = new StreamWriter(strfilepath);
                sw.WriteLine(sb);
                sw.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEquadityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudyOne();

            Console.ReadLine();
        }

        public static void CaseStudyOne()
        {
            Account account1 = new Account("Mayuresh", "C001");

            Account account2 = new Account("Mayuresh", "C001");

            Console.WriteLine(account1==account1);
            Console.WriteLine(account2 == account1);
            Console.WriteLine(account1.Equals(account1));
            Console.WriteLine(account1.Equals(account2));//should be true

            Console.WriteLine(account1);
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
                int num1 = int.Parse(args[0]);
                int num2 = int.Parse(args[1]);

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            //}

            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.StackTrace);

            //}

            Console.WriteLine("End of program");


            //catch (DivideByZeroException ex)
            //{
            //    Console.Write("Cannot divide by zero. Please try again.");
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.Write("Not a valid number. Please try again.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.Write("Not a valid number. Please try again.");
            //}
            Console.ReadLine();
        }
    }
}

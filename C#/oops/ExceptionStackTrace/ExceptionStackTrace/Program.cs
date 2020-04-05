using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionStackTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HashSet<string> objHashStr = new HashSet<string>();
                objHashStr.Add("Harshu");
                objHashStr.Add("Ashish");
                objHashStr.Add("Dipesh");
             

                foreach (object item in objHashStr)
                {
                    Console.WriteLine(item.ToString());
                }

                //M1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("End of Program");
            Console.ReadLine();
        }

        public static void M1()
        {
            Console.WriteLine("M1");
            M2();
        }

        public static void M2()
        {
            Console.WriteLine("M2");
            M3();
        }

        public static void M3()
        {
            Console.WriteLine("M3");
            throw new Exception("Exception occured");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadApp
{
    class OverloadTest
    {
        static void Main(string[] args)
        {
            double objdbl = 10.55;

            Console.WriteLine("Hello",args);
            Console.WriteLine(objdbl);
            Console.WriteLine('#');
            Console.WriteLine(10.555555f);
            Console.WriteLine(true);

            Console.WriteLine("=====PrintInfo=======");

            PrintInfo("Hello");
            PrintInfo(objdbl);
            PrintInfo('#');
            PrintInfo(10.555555f);
            PrintInfo(true);


            Console.ReadLine();
        }

        static void PrintInfo(string strtext)
        {
            Console.WriteLine(strtext);
        }

        static void PrintInfo(bool blnText)
        {
            Console.WriteLine(blnText);
        }

        static void PrintInfo(double dblText)
        {
            Console.WriteLine(dblText);
        }

        static void PrintInfo(char chrText)
        {
            Console.WriteLine(chrText);
        }

        static void PrintInfo(float fltText)
        {
            Console.WriteLine(fltText);
        }


    }
}

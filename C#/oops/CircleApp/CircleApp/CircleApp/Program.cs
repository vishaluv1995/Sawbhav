using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle objCl = new Circle();
            objCl.SetRadius(1.2f);
            objCl.SetColor("BlUE");

            PrintInfo(objCl);

            Console.ReadLine();

        }

        public static void PrintInfo(Circle clTmp)
        {
            Console.WriteLine("Radius = " + clTmp.GetRadius());
            Console.WriteLine("Color = " + clTmp.GetColor());

            Console.WriteLine("Circle Area " + clTmp.CalculateArea());
            Console.WriteLine("Circle Perimeter " + clTmp.Perimeter());
        }

    }
}

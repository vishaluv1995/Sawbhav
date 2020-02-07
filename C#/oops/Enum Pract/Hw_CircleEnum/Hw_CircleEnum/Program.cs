using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_CircleEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;

            Circle objCircle = new Circle();
            objCircle.Radius=5.0f;
            objCircle.Color = BorderColor.Blue;

            PrintMethod(objCircle);
            Console.ReadLine();
        }

        public static void PrintMethod(Circle objCircle)
        {
            Console.WriteLine("Radius - " + objCircle.Radius);
            Console.WriteLine("Circle Area - " + objCircle.CalculateArea);
            Console.WriteLine("Perimeter - " + objCircle.Perimeter);
            Console.WriteLine("Color Style - " + objCircle.Color);
        }
    }
}

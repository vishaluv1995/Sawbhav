using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            Rectangle objRectangle = new Rectangle();
            objRectangle.Weight = 2;
            objRectangle.Height = 4;

            PrintMethd(objRectangle);
            Console.ReadLine();
        }

        public static void PrintMethd(Rectangle objRectangle)
        {
            Console.WriteLine("Weight:"+objRectangle.Weight);
            Console.WriteLine("Height:"+objRectangle.Height);
            Console.WriteLine("Area:"+objRectangle.Area);
            Console.WriteLine("Border Style - " + objRectangle.Border);
            Console.WriteLine("");
        }
    }
}

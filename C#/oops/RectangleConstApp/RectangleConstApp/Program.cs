using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle(10, 20);
            PrintMethod(objRectangle);

            PrintMethod(new Rectangle(30, 40));
            Console.ReadLine();
        }

        public static void PrintMethod(Rectangle objRectangle)
        {
            Console.WriteLine("Width :" + objRectangle.Width());
            Console.WriteLine("Height :" + objRectangle.Height());
            Console.WriteLine("Area :" + objRectangle.Area());
            Console.WriteLine("");
        }
    }
}

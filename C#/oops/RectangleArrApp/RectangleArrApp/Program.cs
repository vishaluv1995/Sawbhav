using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle[] objRectangle = new Rectangle[2];
            objRectangle[0] = new Rectangle(10, 20);
            objRectangle[1] = new Rectangle(30, 40);

            foreach (Rectangle objitem in objRectangle)
            {
                PrintMethod(objitem);
            }

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

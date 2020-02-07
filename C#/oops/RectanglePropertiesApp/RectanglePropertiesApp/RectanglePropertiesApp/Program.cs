using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle objrectangle = new Rectangle();
            objrectangle.Width = 10;
            Console.WriteLine("Width:" + objrectangle.Width);

            objrectangle.Height = 20;
            Console.WriteLine("Height:" + objrectangle.Height);

            Console.WriteLine("CalcArea:" + objrectangle.CalcArea);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Print Info Method");
            PrintInfo(objrectangle);
            PrintInfo(new Rectangle());
            PrintInfo(null);

            Console.ReadLine();
        } 

        public static void PrintInfo(Rectangle objRectangl)
        {
            Console.WriteLine(objRectangl.Width);
            Console.WriteLine(objRectangl.Height);
        }
    }
}

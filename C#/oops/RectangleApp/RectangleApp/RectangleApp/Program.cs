using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int calcarea;
            Rectangle objsmall = new Rectangle();
            objsmall.width = 10;
            objsmall.height = 20;

            Console.WriteLine("Width:"+objsmall.width);
            Console.WriteLine("Height:" + objsmall.height);
            calcarea = objsmall.CalculateArea();
            Console.WriteLine("Area:" + calcarea);
            

            Console.WriteLine("===============================");

            Rectangle objBig = new Rectangle();
            objBig.width = 100;
            objBig.height = 200;
            Console.WriteLine("Width:" + objBig.width);
            Console.WriteLine("Height:" + objBig.height);
            calcarea = objBig.CalculateArea();
            Console.WriteLine("Area:" + calcarea);


            Console.ReadLine();

        }
    }
}

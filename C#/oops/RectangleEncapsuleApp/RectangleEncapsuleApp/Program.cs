using System;

namespace RectangleEncapsuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectanlge objsmall = new Rectanlge();
            objsmall.SetHeight(-200);
            objsmall.SetWidth(105);

            PrintInfo(objsmall);

            Console.WriteLine();

            Rectanlge objBig = new Rectanlge();
            objBig.SetHeight(8);
            objBig.SetWidth(19873677);
            PrintInfo(objBig);

            Rectanlge objTemp = objBig;
            Console.WriteLine(objTemp.GetWidth());
            Console.WriteLine(objBig.GetWidth());

            objTemp.SetWidth(90);
            Console.WriteLine(objTemp.GetWidth());
            Console.WriteLine(objBig.GetWidth());

            Console.WriteLine(objTemp.GetHashCode());

            objTemp = null;
            Console.WriteLine(objBig.GetWidth());
            
            Console.ReadLine();
        }

        public static void PrintInfo(Rectanlge temp)
        {

            Console.WriteLine("Height=" + temp.GetHeight());
            Console.WriteLine("Widht=" + temp.GetWidth());
            Console.WriteLine("Area " + temp.CalculteArea());
            Console.WriteLine(temp.GetHashCode());

        }
    }
}

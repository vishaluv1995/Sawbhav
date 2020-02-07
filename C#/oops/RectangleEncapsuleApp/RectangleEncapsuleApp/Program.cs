using System;

namespace RectangleEncapsuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectanlge objsmall = new Rectanlge();
            objsmall.SetWidth(10);
            objsmall.SetHeight(2);

            PrintInfo(objsmall);

            Console.WriteLine();

            Rectanlge objBig = new Rectanlge();
            objBig.SetWidth(20);
            objBig.SetHeight(2);
            PrintInfo(objBig);

            Rectanlge objTemp = objBig;
            objTemp.SetWidth(1);
            objBig.SetHeight(2);

            objTemp.GetWidth();

            Console.WriteLine(objTemp.GetWidth());
            Console.WriteLine(objBig.GetHeight());

            Console.WriteLine(objTemp.GetHashCode());

            objTemp = null;
            Console.WriteLine(objBig.GetHeight());

            Console.ReadLine();
        }

        public static void PrintInfo(Rectanlge temp)
        {

            Console.WriteLine("Height=" + temp.GetWidth());
            Console.WriteLine("Widht=" + temp.GetHeight());
            Console.WriteLine("Area " + temp.CalculteArea());
            Console.WriteLine(temp.GetHashCode());

        }
    }
}

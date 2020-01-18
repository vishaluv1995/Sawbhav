using System;

namespace RectangleEncapsuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectanlge objsmall = new Rectanlge();
            objsmall.SetHeightWidth(-200);
            objsmall.SetHeightWidth(105);

            PrintInfo(objsmall);

            Console.WriteLine();

            Rectanlge objBig = new Rectanlge();
            objBig.SetHeightWidth(8);
            objBig.SetHeightWidth(19873677);
            PrintInfo(objBig);

            Rectanlge objTemp = objBig;
            Console.WriteLine(objTemp.GetHeightWidth());
            Console.WriteLine(objBig.GetHeightWidth());

            objTemp.SetHeightWidth(90);
            Console.WriteLine(objTemp.GetHeightWidth());
            Console.WriteLine(objBig.GetHeightWidth());

            Console.WriteLine(objTemp.GetHashCode());

            objTemp = null;
            Console.WriteLine(objBig.GetHeightWidth());
            
            Console.ReadLine();
        }

        public static void PrintInfo(Rectanlge temp)
        {

            Console.WriteLine("Height=" + temp.GetHeightWidth());
            Console.WriteLine("Widht=" + temp.GetHeightWidth());
            Console.WriteLine("Area " + temp.CalculteArea());
            Console.WriteLine(temp.GetHashCode());

        }
    }
}

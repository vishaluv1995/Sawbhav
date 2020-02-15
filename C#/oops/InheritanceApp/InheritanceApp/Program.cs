using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Case1();
            Console.WriteLine();

            Case2();
            Console.WriteLine();

            Case3();
            Console.WriteLine();

            Case4();
            Console.WriteLine();

            object x;
            x = 10;
            Console.WriteLine(x.ToString());
            Console.WriteLine("object type:" + x.GetType());
            Console.WriteLine("object HashCode:" + x.GetHashCode());

            x = "kishore";
            Console.WriteLine(x.ToString());
            Console.WriteLine("object type:" + x.GetType());
            Console.WriteLine("object HashCode:" + x.GetHashCode());

            x = new Man();
            Console.WriteLine(x.ToString());
            Console.WriteLine("object type:" + x.GetType());
            Console.WriteLine("object HashCode:" + x.GetHashCode());

            x = new Child();
            Console.WriteLine(x.ToString());
            Console.WriteLine("object type:" + x.GetType());
            Console.WriteLine("object HashCode:" + x.GetHashCode());

            x = new Boy();
            Console.WriteLine(x.ToString());
            Console.WriteLine("object type:" + x.GetType());
            Console.WriteLine("object HashCode:" + x.GetHashCode());

            Console.Read();
        }

        private static void Case4()
        {
            Console.WriteLine("Case 4");
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Child());
            AtThePark(new Infant());
        }

        private static void Case3()
        {
            Console.WriteLine("Case 3");
            Man man2 = new Boy();
            man2.Play();
            man2.Read();
        }

        private static void Case2()
        {
            Console.WriteLine("Case 2");
            Boy boy = new Boy();
            boy.Play();
            boy.Eat();
            boy.Walk();
        }

        private static void Case1()
        {
            Console.WriteLine("Case 1");
            Man man1 = new Man();
            man1.Play();
            man1.Read();
        }

        public static void AtThePark(Man man)
        {
            man.Play();
            man.Read();
        }

    }
}

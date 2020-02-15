using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child2 = new Child();
            Console.WriteLine(child2.GetFoo);

            Child child = new Child(200);
            Console.WriteLine(child.GetFoo);

            ConstructorCase1.Child child3 = new ConstructorCase1.Child();
            Console.WriteLine(child3.GetFoo);

            ConstructorCase2.Child child4 = new ConstructorCase2.Child(700);
            Console.WriteLine(child4.GetFoo);

            Console.Read();
        }
    }
}

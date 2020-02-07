using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human objHuman = new Human("Vishal", GenderType.Male, 5.8f, 80, 24);
            Console.WriteLine("Before Workout");
            PrintMethod(objHuman);
            Console.WriteLine("After workout");
            objHuman.weightloss();
            PrintMethod(objHuman);

            Human objHuman2 = new Human("Kishore", GenderType.Male);
            Console.WriteLine("Before Workout");
            PrintMethod(objHuman2);
            Console.WriteLine("After workout");
            objHuman2.weightloss();
            PrintMethod(objHuman2);
            Console.ReadLine();
        }

        public static void PrintMethod(Human objHuman)
        {
            Console.WriteLine("Name :"+objHuman.Name());
            Console.WriteLine("Gender :" + objHuman.Gender());
            Console.WriteLine("Weight :" + objHuman.Weight());
            Console.WriteLine("Height :" + objHuman.Heigth());
            Console.WriteLine("Age :" + objHuman.Age());
            Console.WriteLine("");
        }
    }
}
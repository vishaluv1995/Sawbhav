using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePolymorphism.ManBoy;
using InterfacePolymorphism.Vehicle;

namespace InterfacePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();

            Case2();

            Console.ReadLine();
        }

        private static void Case2()
        {
            IMovable[] movables = new IMovable[3];
            movables[0] = new Bike();
            movables[1] = new Car();
            movables[2] = new Truk();

            Console.WriteLine("Start Race");
            foreach (IMovable item in movables)
            {
                StartRace(item);
            }
        }

        private static void Case1()
        {
            ManBoy.Boy x = new ManBoy.Boy();
            ManBoy.Man y = new ManBoy.Man();

            AtTheParty(x);
            AtTheParty(y);
            AtTheMovie(x);
            //AtTheMovie(y);
        }

        public static void AtTheParty(IMannerable mannerable)
        {
            Console.WriteLine("At the party");
            mannerable.Wish();
            mannerable.Depart();
            Console.WriteLine();
        }

        public static void AtTheMovie(IEmotional emotional)
        {
            Console.WriteLine("At the movie hall");
            emotional.Cry();
            emotional.Laugh();
            Console.WriteLine();
        }

        public static void StartRace(IMovable movable)
        {
            movable.Move();
        }
    }
}

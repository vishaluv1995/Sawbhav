using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Player");
            Player p1 = new Player(1, "Ashish", 25);
            Print(p1);

            Console.WriteLine("Second Player");
            Player p2 = new Player(2, "Dipesh", 28);
            Print(p2);

            Console.WriteLine("Elder is");
            Print(p1.Whoiselder(p2));

            Console.ReadLine();
        }

        public static void Print(Player objplayer)
        {
            Console.WriteLine("Id:" + objplayer.Id);
            Console.WriteLine("Name:" + objplayer.Name);
            Console.WriteLine("Age:" + objplayer.Age);
            Console.WriteLine("Hash Code:"+objplayer.GetHashCode());
            Console.WriteLine("");
        }
    }
}

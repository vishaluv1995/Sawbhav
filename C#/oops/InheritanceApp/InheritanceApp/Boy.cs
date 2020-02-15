using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Boy : Man
    {
        public override void Play()
        {
            Console.WriteLine("Play:Boy");
        }

        public  void Eat()
        {
            Console.WriteLine("Eat:Boy");
        }

        public  void Walk()
        {
            Console.WriteLine("Walk:Boy");
        }

        //public override void Eat()
        //{
        //    Console.WriteLine("Eat:Boy");
        //}

        //public override void Walk()
        //{
        //    Console.WriteLine("Walk:Boy");
        //}
    }
}

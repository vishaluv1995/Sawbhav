using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Play:Man");
        }

        public void Read()
        {
            Console.WriteLine("Read:Man");
        }

        //public virtual void Eat()
        //{
        //    Console.WriteLine("Eat:Man");
        //}

        //public virtual void Walk()
        //{
        //    Console.WriteLine("Walk:Man");
        //}         
    }
}

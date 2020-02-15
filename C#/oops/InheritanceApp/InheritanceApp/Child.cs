using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Child : Man
    {
        public override void Play()
        {
            Console.WriteLine("Play:Child");
        }
    }
}

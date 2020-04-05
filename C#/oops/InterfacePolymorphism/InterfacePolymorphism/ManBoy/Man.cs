using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism.ManBoy
{
    class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine("Man Depart");
        }

        public void Wish()
        {
            Console.WriteLine("Man Wish");
        }
    }
}

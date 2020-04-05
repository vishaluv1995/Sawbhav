using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism.Vehicle
{
    class Truk : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Truk move");
        }
    }
}

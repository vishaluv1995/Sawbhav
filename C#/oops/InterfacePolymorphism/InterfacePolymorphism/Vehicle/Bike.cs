using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism.Vehicle
{
    class Bike : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bike Move");
        }
    }
}

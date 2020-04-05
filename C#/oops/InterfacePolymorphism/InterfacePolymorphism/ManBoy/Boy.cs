using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePolymorphism.ManBoy
{
    class Boy : IEmotional, IMannerable
    {
        public void Cry()
        {
            Console.WriteLine("Boy cry");
        }

        public void Depart()
        {
            Console.WriteLine("Boy Depart");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy Laugh");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Wish");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp.ConstructorCase1
{
    class Child:Parent
    {
        public Child(int foo):base(foo)
        {

        }

        public Child():base(100)
        {

        }

       
    }
}

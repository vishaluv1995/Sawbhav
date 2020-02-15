using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConstructorApp.ConstructorCase2
{
    class Child:Parent
    {
        public Child():base(200)
        {

        }

        public Child(int foo):base(foo)
        {

        }
    }
}

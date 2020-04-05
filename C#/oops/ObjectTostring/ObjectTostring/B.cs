using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTostring
{
    class B : A
    {
        public override string Foo()
        {
            return base.Foo() +"&"+ "Child Foo";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowNew
{
    class Foo : Exception
    {
        private int num;

        public Foo(int i)
        {
            num = i;
        }

        public int Number
        {
            get
            {
                return num;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowNew
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Foo foo = new Foo(int.Parse("Harshu"));
            }
            catch (Exception)
            {
                throw new Foo(1);
            }
        }
    }
}

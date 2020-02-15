using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentObjChild
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent objP = new Child();
            objP.FirstResult(1, 2);
           
        }
    }
}

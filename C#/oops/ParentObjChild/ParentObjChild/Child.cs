using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentObjChild
{
    public class Child : Parent
    {
        public int _balC;

        public int SecondResult(int thirdNo, int fourthNo)
        {
            return thirdNo + fourthNo;
        }

      
    }
}

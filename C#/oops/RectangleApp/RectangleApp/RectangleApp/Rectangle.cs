using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Rectangle
    {
        public int width;
        public int height;

        public int CalculateArea()
        {
            int total = width * height;
            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsuleApp
{
    class Rectanlge
    {
        private int _width;
        private int _height;

        public int CalculteArea()
        {
            return _width * _height;
        }
        
        public void SetWidth(int num)
        {
            _width = CorrectDimension(num);
        }

        public void SetHeight(int num)
        {
            _height = CorrectDimension(num);
        }

        private int CorrectDimension(int num)
        {
            if (num <= -1)
            {
                return 1;
            }

            if (num > 100)
            {
                return 100;
            }

            return num;
        }

        public int GetHeight()
        {
            return _height;
        }
        public int GetWidth()
        {
            return _width;
        }
    }

}

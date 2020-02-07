using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesApp
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = Validate(value);
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = Validate(value);
            }
        }

        public int CalcArea
        {
            get
            {
                return _width * _height;
            }
        }

        public int Validate(int getVal)
        {
            if (getVal <= -1)
            {
                return 1;
            }

            if (getVal > 100)
            {
                return 100;
            }

            return getVal;
        }
    }
}

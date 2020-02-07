using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Rectangle
    {
        private int _weight;
        private int _height;
        private int _area;
        private BorderOptions _border;

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public int Area
        {
            get
            {
                _area = _weight * _height;
                return _area;
            }
        }

        public BorderOptions Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }
    }
}

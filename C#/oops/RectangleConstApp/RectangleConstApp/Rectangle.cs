using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private int _area;

        public Rectangle(int Width, int Height)
        {
            _width = Width;
            _height = Height;
            Console.WriteLine("Rectangle Created");
        }

        public int Width()
        {
            return _width;
        }

        public int Height()
        {
            return _height;
        }

        public int Area()
        {
            return _area = _width * _height;
        }
    }
}

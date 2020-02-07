using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private BorderOptions border;

        public enum BorderOptions
        {
            SINGLE,
            DOTTED,
            DOUBLE
        }

        public void SetBorderOption(BorderOptions objborder)
        {
            BorderOptions = objborder.ToString();
        }

        public BorderOptions GetBorder()
        {
            return enum;
            return enum;
        }
    }
}

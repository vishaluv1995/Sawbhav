using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_CircleEnum
{
    class Circle
    {
        private float _radius;
        private float _area;
        private float _perimeter;
        private BorderColor _color;

        public float Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public float CalculateArea
        {
            get
            {
                return (float)Math.Round(3.14f * _radius * _radius, 2, MidpointRounding.AwayFromZero);
            }
            set
            {
                _area = value;
            }
        }

        public float Perimeter
        {
            get
            {
                return (float)Math.Round(2 * 3.14f * _radius, 2,
                 MidpointRounding.AwayFromZero);
            }
            set
            {
                _perimeter = value;
            }

        }

        public BorderColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
    }
}

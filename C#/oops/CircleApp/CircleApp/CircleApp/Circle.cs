using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        private float _radius;
        private string _color;
        public float CalculateArea()
        {
            return (float)Math.Round(3.14f * _radius * _radius, 2, MidpointRounding.AwayFromZero);
        }

        public float Perimeter()
        {
            return (float)Math.Round(2 * 3.14f * _radius, 2, MidpointRounding.AwayFromZero);
        }

        public void SetRadius(float rad)
        {
            _radius = rad;
        }

        public void SetColor(string color)
        {
            color = color.ToUpper();
            if ((color == "RED") || (color == "GREEN") || (color == "BLUE"))
            {
                _color = color;
                return;
            }

            _color = "RED";

        }

        public float GetRadius()
        {
            return _radius;
        }
        public String GetColor()
        {
            return _color;
        }
    }
}

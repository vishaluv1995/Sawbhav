using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle2
{
    class Circle
    {
        private float Radius;
        private string Color;

        public void setRadius(float getRadsVal)
        {
            Radius = getRadsVal;
        }
        public void setColor(string getColor)
        {
            Color = getColor;
        }
        public float getRadius()
        {
            return Radius;
        }
        public string getColor()
        {
            return Color;
        }

        public float CalcArea()
        {
            return 1.0f;
        }

        public float Delimeter()
        {
            return 1.0f;
        }
    }
}

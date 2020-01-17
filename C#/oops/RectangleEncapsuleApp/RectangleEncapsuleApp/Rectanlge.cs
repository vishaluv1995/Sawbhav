using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsuleApp
{
    class Rectanlge
    {
        private int width;
        private int height;
        public int CalculteArea()
        {
            return width * height;
        }
        public void SetWidth(int pwidth)
        {
            if (pwidth <= -1)
            {
                width = 1;
            }
            else if (pwidth > 100)
            {
                width = 100;
            }
            else
            {
                width = pwidth;
            }
        }
        public void SetHeight(int pheight)
        {
            if (pheight <= -1)
            {
                height = 1;
            }
            else if (pheight > 100)
            {
                height = 100;
            }
            else
            {
                height = pheight;
            }
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetWidth()
        {
            return width;
        }
    }

}

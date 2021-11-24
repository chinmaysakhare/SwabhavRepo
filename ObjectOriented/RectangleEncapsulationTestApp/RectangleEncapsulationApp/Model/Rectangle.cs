using System;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
        private int width;
        private int height;
        public void SetWidth(int a)
        {
            width = CorrectDimensons(a);
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetHeight(int a)
        {
            height = CorrectDimensons(a);
        }
        public int GetHeight()
        {
            return height;
        }
        private int CorrectDimensons(int a)
        {
            int correctDimension = 0;
            if (a > 0)
            {
                correctDimension = a;
            }
            else if (a <= 0)
            {
                correctDimension = 1;
            }
            else if (a > 100)
            {
                correctDimension = 100;
            }
            return correctDimension;
        }


    }
}

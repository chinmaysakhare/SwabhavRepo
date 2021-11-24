using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Module
{
    class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        public Rectangle(int a, int b, string c)
        {
            _width = a;
            _height = b;
            if (c == "green" || c == "blue" || c == "red")
                _color = c;
            else
                _color = "blue";
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }
        public string GetColor()
        {
            return _color;
        }
        public int GetArea()
        {
            return _width * _height;
        }
    }
}

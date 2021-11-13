using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Module
{
    class RectangleEnum
    {
       
        private int _width;
        private int _height;
        private ColorType _borderColor;
        public RectangleEnum()
        {
            Console.WriteLine("Rectangle Created");
            _borderColor = ColorType.RED;
        }
        public int SetWidth
        {
            set
            {
                if (value > 100)
                {
                    _width = 100;
                }
                else
                    _width = value;
            }
            get
            {
                return _width;
            }
        }
        public int SetHeight
        {
            set 
            {
                if (value > 100)
                {
                    _height = 100;
                }
                else
                    _height = value;
            }
            get 
            {
                return _height;
            }
        }
        public ColorType SetBorderColor
        {
            set 
            {
                _borderColor = value;
            }
            get 
            {
                return _borderColor;
            }
        }
        
    }
}

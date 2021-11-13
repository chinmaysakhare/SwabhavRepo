using System;


namespace Circle.Module
{
    class Circle
    {
        private float _radius;
        private String _borderColor;
        private String _fillColor;
        public float GetRadius()
        {
            return _radius;
        }
        public String GetBorderColor()
        {
            return _borderColor;
        }
        public String GetFillColor()
        {
            return _fillColor;
        }
        public Circle(float a,string b,string c)
        {
            validate(a);
            string bColor, fColor;
            bColor = validate(b);
            fColor = validate(c);
            _borderColor = bColor;
            _fillColor = fColor;
        }
        private void validate(float radius)
        {
            if (radius <= 0)
                _radius = 1;
            else if (radius > 100)
                _radius = 100;
            else
                _radius = radius;
        }
        private string validate(String color)
        {
            color = color.ToLower();
            if (string.Equals(color, "red") || string.Equals(color, "green") || string.Equals(color, "blue"))// || string.Equals(Color, "RED") || string.Equals(Color, "GREEN") || (string.Equals(Color, "BLUE")))
                return color;
            else
            {
                color = "red";
                return color;
            }
        }
    }
}


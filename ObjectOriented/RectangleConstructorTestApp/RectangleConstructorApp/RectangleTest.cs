using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Module
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20, "red");
            PrintDetails(r);
            Rectangle r1 = new Rectangle(15, 13, "green");
            PrintDetails(r1);
            Rectangle r2 = new Rectangle(45, 8, "yellow");
            PrintDetails(r2);
            HighestArea(r1, r2, r);



        }
        public static void PrintDetails(Rectangle obj)
        {
            Console.WriteLine(obj.GetWidth());
            Console.WriteLine(obj.GetHeight());
            Console.WriteLine(obj.GetColor());
        }
        public static void HighestArea(Rectangle a, Rectangle b, Rectangle c)
        {
            int h = a.GetArea() > b.GetArea() ? a.GetArea() : b.GetArea();
            int h1 = h > c.GetArea() ? h : c.GetArea();
            Console.WriteLine("The highest Area is :-" +h1);
            Console.ReadLine();
        }
    }
}

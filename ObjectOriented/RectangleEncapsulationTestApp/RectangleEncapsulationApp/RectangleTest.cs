using System;


namespace RectangleEncapsulationApp.Model
{
    class RectangleTest
    {
        static void Main(string[] args)
        {
            Rectangle small = new Rectangle();
            small.SetWidth(-10);
            small.SetHeight(40);
            Console.WriteLine(small.GetWidth());
            Console.WriteLine(small.GetHeight());
            Console.ReadLine();
        }
    }
}

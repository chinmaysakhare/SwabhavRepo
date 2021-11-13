using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEnumApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.BackgroundColor = ConsoleColor.Red;
            RectangleEnum obj = new RectangleEnum();
            PrintDetails(obj);
            Console.ReadLine();
            obj.SetHeight = 20;
            obj.SetWidth = 120;
            obj.SetBorderColor =ColorType.BLUE;
            PrintDetails(obj);
            Console.ReadLine();
        }
        public static void PrintDetails(RectangleEnum o)
        {
            Console.WriteLine(o.SetHeight);
            Console.WriteLine(o.SetWidth); 
            Console.WriteLine(o.SetBorderColor);
        }
    }
}

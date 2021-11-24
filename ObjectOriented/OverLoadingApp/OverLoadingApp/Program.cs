using System;

namespace OverLoadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintDetailss(10);
            PrintDetailss("Hello");
            PrintDetailss(11000.00);
            PrintDetailss(123.3f);
            PrintDetailss(true);
            PrintDetailss('i');
            Console.ReadLine();
        }
        private static void PrintDetailss(int content)
        {
            Console.WriteLine("Overload 1 : String Type"+content);
        }
        private static void PrintDetailss(string content)
        {
            Console.WriteLine("OverLoad 2 : String type" + content);
        }
        private static void PrintDetailss(double content)
        {
            Console.WriteLine("OverLoad 3 : Double type : " + content); 
        }
        private static void PrintDetailss(float content)
        {
            Console.WriteLine("OverLoad 4 Float type : " + content);
        }
        private static void PrintDetailss(bool content)
        {
            Console.WriteLine("OverLoad 5 Boolean type : " + content);
        }
        private static void PrintDetailss(char content)
        {
            Console.WriteLine("OverLoad 6 Char type :" +content);
        }
    }
}

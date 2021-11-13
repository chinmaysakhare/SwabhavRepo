using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCallStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { m1(); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.StackTrace); 
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("End Of main");
                Console.ReadLine();
            }

           


        }
        public static void m1()
        {
            Console.WriteLine("Inside M1");
            m2();
        }
        public static void m2()
        {
            Console.WriteLine("Inside M2");
            m3();
        }
        public static void m3()
        {
            Console.WriteLine("Inside M3");
            throw new Exception("Some things went wrong in m3");
        }
    }
}

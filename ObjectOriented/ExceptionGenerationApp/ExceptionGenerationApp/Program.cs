using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionGenerationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNo = Convert.ToInt32(args[0]);
            int secondNo = Convert.ToInt32(args[1]);
            int result = firstNo / secondNo;
            Console.WriteLine("First no : "+firstNo+"second No : "+secondNo+"Result : "+ result);
            //Console.ReadLine();
            Console.WriteLine("End of Main");
            Main(args);
        }
    }
}
/*
 * try
            {
                int firstNo = Convert.ToInt32(args[0]);
                
            }
            catch (System.IndexOutOfRangeException) 
            {
                Console.WriteLine("Program");
                Console.WriteLine("15");
            }
            try
            {
                int secondNo = Convert.ToInt32(args[1]);

            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Program");
                Console.WriteLine("31");
            }
            try
            {
                int firstNo = Convert.ToInt32(args[0]);
                int secondNo = Convert.ToInt32(args[1]);
                int result = firstNo / secondNo;

            }
            catch
            {
                                 
                Console.WriteLine("Program");
                Console.WriteLine("35,36,37");
            }
 */
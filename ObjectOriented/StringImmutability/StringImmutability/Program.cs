using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutability
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Str =  Hello world";
            unsafe 
            {
                int var = 5;
                int* ptr = &var;
                Console.WriteLine("Var value : "+var);
                Console.WriteLine("Var Address: "+ ((int)ptr)) ;
                var += 2;
                Console.WriteLine("Var value : "+var);
                Console.WriteLine("Var Address: " + ((int)ptr));
            }
            
            Console.WriteLine(str);
            Console.WriteLine("Str Address : " + str.GetHashCode()); 
            str += " edited";
            Console.WriteLine(str);
            Console.WriteLine("Str Address : " + str.GetHashCode());
            Console.ReadLine();
            Console.WriteLine("We can see two diffrent memory loc for the same string.\nThis proves that the old str is deleted using gc and the new string is alloacted diffrent memory ref");
            Console.ReadLine();

        }
    }
}

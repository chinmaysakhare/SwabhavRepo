using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CustomAttribute.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            int count = 0;
            foreach (var type in types)
            {
                var methods = type.GetMethods().Where(t => t.GetCustomAttributes<NeedToRefactor>().Count()>0);
                foreach (var method in methods)
                {
                    count++;
                    Console.WriteLine("Methods With attribute are : "+method);
                }

            }
            Console.WriteLine("There are " + count + " Methods with Attributes");
            Console.ReadLine();
        }
        public static void GetAttribute()
        {

        }
    }
}
/*
 
 
 
 foreach (var type in types)
            {
                var methods = type.GetMethods();
                foreach (var method in methods)
                { 
                    
                    Console.WriteLine(method);

                    var attr = method.GetCustomAttribute();
                    Console.WriteLine(attr);
                }
                 
            }
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySyntaxApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Enum obj = new Enum();
            Console.WriteLine(obj.Bar);
            obj.Bar = 200;
            Console.WriteLine(obj.Bar);
            //obj.Baz = 100;
            Console.WriteLine(obj.Baz);
            Console.WriteLine(obj.Baz);
            Console.ReadLine();

        }
    }
}

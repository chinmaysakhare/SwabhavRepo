using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            IHat hat = new RibbonHat(new GoldenHat(new PremiumHat()));
            Console.WriteLine("Hat 1 Details : ");
            Console.WriteLine("\n Name of the Hat : "+hat.getName());
            Console.WriteLine("\n Features of the Hat :- " + hat.getDescription());
            Console.WriteLine("\n Total Price :- "+hat.getPrice());
            

            IHat hat1=new RibbonHat(new GoldenHat(new StandardHat()));
            Console.WriteLine("\n\n Hat 2 Details : ");
            Console.WriteLine("\n Name of the Hat : " + hat1.getName());
            Console.WriteLine("\n Features of the Hat :- " + hat1.getDescription());
            Console.WriteLine("\n Total Price :- " + hat1.getPrice());
            Console.ReadKey();
        }
    }
}

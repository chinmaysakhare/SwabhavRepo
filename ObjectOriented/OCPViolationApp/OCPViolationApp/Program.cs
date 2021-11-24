using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Chinmay", 100000, 5, FixedDeposit.Festivals.Normal);
            Console.WriteLine("Rate of intrest : "+fd1.CalcRateOfIntrest());
            Console.WriteLine("Simple Intrest : "+fd1.CalcSimpleIntrest());
            Console.ReadLine();
        }
    }
}

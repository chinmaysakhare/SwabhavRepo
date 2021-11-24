using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolation.HighLevelModule
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new TaxCalculator(TaxCalculator.LogType.DB);
            Console.WriteLine(cal.Calculate(10, 5));
            Console.WriteLine(cal.Calculate(10,0));
            Console.ReadKey();
        }
    }
}

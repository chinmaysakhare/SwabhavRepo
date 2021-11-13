using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Module
{
    class InvoiceConsolePrinter
    {
        public InvoiceConsolePrinter(Invoice obj)
        {
            PrintDetails(obj);
        }

        public void PrintDetails(Invoice obj)
        {
            Console.WriteLine("ID : " + obj.Id);
            Console.WriteLine(obj.Description);
            Console.WriteLine("Initial Amount : " + obj.Amount);
            Console.WriteLine("Tax : " + obj.Tax * 100 + " %");
            Console.WriteLine("Discount : " + obj.Discount * 100 + "%");
            Console.WriteLine("Tax Deductions : " + obj.CalculateTax());
            Console.WriteLine("Discount Addition : " + obj.CalculateDiscount());
            Console.WriteLine("Final Amount : : " + obj.CalculateFinalAmount());
        }
    }
}

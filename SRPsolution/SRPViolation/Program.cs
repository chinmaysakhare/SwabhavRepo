using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(1, "New Invoice For Chinmay", 100, 0.1f,0.05f) ;
            inv.CalculateTax();
            inv.CalculateDiscount();
            inv.CalculateFinalAmount();
            inv.PrintDetails();
            Console.ReadLine();
        }
       

        
    }
}

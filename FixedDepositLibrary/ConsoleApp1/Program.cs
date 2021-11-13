using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixedDepositLibrary;

namespace FixedDepositLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fd1 = new FixedDeposit("Chinmay", 10000, 10, new DiwaliFestivalPolicy());
            Console.WriteLine("Simple Intrest : " + fd1.CalcSimpleIntrest());
            Console.ReadKey();
        }

    }
}
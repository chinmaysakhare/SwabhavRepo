using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringApp.Module
{
    class Program
    {

        static void Main(string[] args)
        {
            ToStringMain p1 = new ToStringMain(100, "Chinmay", 677.2);
            ToStringMain p2 = new ToStringMain(100, "Vinay", 677.2);
            Console.WriteLine(p1 == p2);
            Console.WriteLine((p1.equals(p2))); 
            Console.ReadLine();
        }
    }

}

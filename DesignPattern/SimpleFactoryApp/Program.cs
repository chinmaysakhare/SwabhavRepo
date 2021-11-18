using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Factory;

namespace SimpleFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var f1 = new AutoMobileFactory();
            var auto = f1.make(AutoType.TESLA);
            auto.start();
            auto.stop(); */
            var f1 = AutoMobileFactory.GetInstance();
            var auto = f1.make(AutoType.AUDI);
            auto.start();
            auto.stop();
            Console.WriteLine(f1.GetHashCode());
            var f2 = AutoMobileFactory.GetInstance();
            var auto2 = f2.make(AutoType.BMW);
            auto2.start();
            auto2.stop();
            Console.WriteLine(f2.GetHashCode());
            Console.ReadKey();
        }
    }
}

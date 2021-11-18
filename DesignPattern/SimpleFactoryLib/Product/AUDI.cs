using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    class AUDI:IAuto
    {
        public void start()
        {
            Console.WriteLine("Audi started");
        }
        public void stop()
        {
            Console.WriteLine("Audi has stopped");
        }
    }
}

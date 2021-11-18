using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    class TESLA:IAuto
    {
        public void start()
        {
            Console.WriteLine("Tesla started");
        }
        public void stop()
        {
            Console.WriteLine("Tesla has stopped");
        }
    }
}

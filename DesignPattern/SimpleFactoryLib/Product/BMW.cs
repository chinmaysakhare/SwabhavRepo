using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    class BMW:IAuto
    {
        public void start()
        {
            Console.WriteLine("BMW started");
        }
        public void stop()
        {
            Console.WriteLine("BMW has stopped");
        }
    }
}

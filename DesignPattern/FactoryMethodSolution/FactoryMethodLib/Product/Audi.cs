using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine(" Audi Started");
        }

        public void Stop()
        {
            Console.WriteLine(" Audi Stoped");
        }
    }
}

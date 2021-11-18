using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib.Product
{
    internal class Bmw : IAuto
    {
        public void Start()
        {
            Console.WriteLine(" Bmw Started");
        }

        public void Stop()
        {
            Console.WriteLine(" Bmw Stoped");
        }
    }
}

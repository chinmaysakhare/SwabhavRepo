using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram.Module
{
    class Man:Imanner
    {
        public void Depart()
        {
            Console.WriteLine("Boy is Departing");
        }
        public void Wish()
        {
            Console.WriteLine("Boy is Wishing");
        }
    }
}

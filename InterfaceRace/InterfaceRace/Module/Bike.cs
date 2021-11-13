using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRace.Module
{
    class Bike:IMoveable
    {
        public void  Move()
        {
            Console.WriteLine("Bike is Moving"); 
        }
    }
}

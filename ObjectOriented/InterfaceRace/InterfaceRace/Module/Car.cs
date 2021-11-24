using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRace.Module
{
    class Car:IMoveable
    {

        public void Move()
        {
            Console.WriteLine("Car is Moving");
        }
    }
}

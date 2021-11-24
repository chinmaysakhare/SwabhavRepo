using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceRace.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoveable[] race = { new Car(), new Truck(), new Bike() };
            StartRace(race);
            Console.ReadLine();
        }
        public static void StartRace(IMoveable[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i].Move();
            }
        }
    }
}

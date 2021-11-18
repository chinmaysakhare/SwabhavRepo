using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService car = new TyreBalance(new CarInspection());
            Console.WriteLine(" Car 1 Service Details");
            Console.WriteLine(car.getDescription());
            Console.WriteLine("\n Total Price : "+car.getCost());

            ICarService car2 = new OilChange(new CarInspection());
            Console.WriteLine("\n\n Car 2 Service Details");
            Console.WriteLine(car2.getDescription());
            Console.WriteLine("\n Total Price : " + car2.getCost());
            Console.ReadLine();

        }

    }
}

using FacadeDesignPatternApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCLIENT ORDERS FOR PIZZA\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegPizza();
            facadeForClient.GetVegPizza();
            Console.WriteLine("\n\t\t\tCLIENT ORDERS FOR BREAD\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
            Console.ReadLine();
        }
    }
}

using GuitarApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 1499.5, "fender", "Stratocastor", "electric", "Alder", "Alder");

            Guitar guitar = inventory.search(whatErinLikes);
            if (guitar != null)
            {
                Console.WriteLine("Erin, you might like this" + guitar.Getbuilder() + "" +
                    guitar.Getmodel() + "" + guitar.Gettype() + "guitar:\n" +
                    guitar.GetbackWood() + "back and sides,\n" + guitar.GettopWood() +
                    "top.\n You can have it for onlu $" + guitar.Getprice() + "!");
            }
            else
            {
                Console.WriteLine(" Sorry,Erin we have nothing for you");
            } 
            Console.ReadLine();
        }

        private static void initializeInventory(Inventory inventory)
        {
            
            
            
        }
    }
}

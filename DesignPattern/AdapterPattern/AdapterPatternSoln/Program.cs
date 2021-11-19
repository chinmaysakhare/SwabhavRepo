    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemExternalLib;
using ShoppingCartClientApp;

namespace AdapterPatternSoln
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new ShoppingCart();
            c.addItem(new HatToAdapter(new Hat("Golden", "Golden Premium Hat", 600.75)));
            Console.WriteLine("Price: "+c.totalPrice());
            Console.ReadLine();

        }
    }
}

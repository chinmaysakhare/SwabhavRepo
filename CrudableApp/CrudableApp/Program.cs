using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperations(new ProductDB());
            Console.ReadLine();
            DoDBOperations(new OrderDB());
            Console.ReadLine();
            DoDBOperations(new PremiumCustomerDB());
            Console.ReadLine();
        }
        public static void DoDBOperations(ICrudable obj)
        {
            Console.WriteLine("Doing all DB ops, Pls Wait ");
            obj.Read();
            obj.Create();
            obj.Read();
            obj.Delete();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    class PremiumCustomerDB : CustomerDB
    {
        public override void Create()
        {
            Console.WriteLine("Customer data Created");
        }
        public override void Read()
        {
            Console.WriteLine("Customer data read");
        }
    }
}

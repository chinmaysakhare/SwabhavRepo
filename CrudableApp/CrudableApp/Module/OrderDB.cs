using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    class OrderDB: ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Order data created");
        }
        public void Read()
        {
            Console.WriteLine("Order data read");
        }
        public void Update()
        {
            Console.WriteLine("Order data updated");
        }
        public void Delete()
        {
            Console.WriteLine("order data deleted");
        }
    }
}

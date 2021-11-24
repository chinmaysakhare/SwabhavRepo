using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    class ProductDB:ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Product data Created");
        }
        public void Read()
        {
            Console.WriteLine("Product data Read");
        }
        public void Update()
        {
            Console.WriteLine("Product data Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Product data Deleted");
        }
    }
}

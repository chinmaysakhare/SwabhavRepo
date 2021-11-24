using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudableApp.Module
{
    abstract class CustomerDB: ICrudable
    {
        abstract public void Create();
        abstract public void Read();
        public void Update() { Console.WriteLine("Customer Data Updated"); }
        public void Delete() { Console.WriteLine("Customer Data Deleted"); }
    }
}

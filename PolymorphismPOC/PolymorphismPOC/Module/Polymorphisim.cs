using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPOC.Module
{
    class Polymorphisim
    {
        public int varWithSameName = 20;
        public void Method()
        {
            Console.WriteLine("Method in super class.");   
        }
    }
   
    class PolymorphisimSubClass : Polymorphisim

    {
        public int varWithSameName = 30;


         new public void Method()
        {
            Console.WriteLine("Method in sub class.");
        }
    }
}

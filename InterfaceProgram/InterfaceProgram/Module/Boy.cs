using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProgram.Module
{
    class Boy:Imanner,IEmotion
    {
        public void Wish()
        {
            Console.WriteLine("Man is Wishing");
        }
        public void Depart()
        {
            Console.WriteLine("Man is Departing");
        }
        public void Laugh()
        {
            Console.WriteLine("Man is Laughing");
        }
        public void Cry()
        {
            Console.WriteLine("Man is Crying");
        }

    }
}

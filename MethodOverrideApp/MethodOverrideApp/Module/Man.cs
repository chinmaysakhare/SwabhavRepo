using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApp.Module
{
    class Man
    {
         public void Read()
        {
            Console.WriteLine(" Man is Reading");
        }
        virtual public void Play()
        {
            Console.WriteLine(" Man is Playing");
        }
        public void walk()
        {
            Console.WriteLine(" Man is walking");
        }

    }

}

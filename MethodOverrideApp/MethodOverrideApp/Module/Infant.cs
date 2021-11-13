using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApp.Module
{
    class Infant:Man
    {
        public override void Play()
        {
            Console.WriteLine("Infant is Playing");
        }
    }
}

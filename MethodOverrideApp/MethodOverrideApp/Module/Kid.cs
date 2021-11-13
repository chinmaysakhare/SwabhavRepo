using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApp.Module
{
    class Kid:Man
    {
        public override void Play()
        {
            Console.WriteLine("Kid is Playing");
        }
    }
}

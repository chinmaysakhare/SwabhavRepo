using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrideApp.Module
{
    class Boy : Man
    {
        public void Jump()
        {
            Console.WriteLine(" Boy is Jumping");
        }
        public override void Play()
        {
            Console.WriteLine(" Boy is Playing");
        }

    }
}

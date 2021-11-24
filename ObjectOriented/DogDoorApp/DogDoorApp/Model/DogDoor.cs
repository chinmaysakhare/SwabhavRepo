using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    public class DogDoor
    {
        private bool open;
        
        public DogDoor()
        {
            this.open = false;
        }
        public void Open()
        {
            Console.WriteLine(" The dog door is now open");
            open = true;
        }
        public void close()
        {
            Console.WriteLine(" The dog door is now close");
            open = false;
        }
        public bool isOpen()
        {
            return open;
        }
    }
}

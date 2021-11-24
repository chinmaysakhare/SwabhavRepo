﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Model
{
    public class Remote
    {
        private DogDoor door;

        public Remote(DogDoor door)
        {
            this.door = door;
        }
        public void pressButton()
        {
            Console.WriteLine("Remote control button pressed");
            if (door.isOpen())
            {
                door.close();
            }
            else
            {
                door.Open();
            }
        }
    }
}

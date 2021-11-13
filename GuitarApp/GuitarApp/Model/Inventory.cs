using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(string SerialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            Guitar guitar = new Guitar(SerialNumber,price, builder, model, type, backWood, topWood);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(string SerialNumber)
        {
            foreach(var guitar in guitars)
            {

                if (guitar.GetSerialNumber().Equals(SerialNumber))
                {
                    return guitar;
                }
            }
            return null;

        }
        public Guitar search(Guitar searchGuitar)
        {
            foreach (var guitar in guitars)
            {

                string builder = searchGuitar.Getbuilder();
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.Getbuilder())))
                    continue;

                string model = searchGuitar.Getmodel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.Getmodel())))
                    continue;
                 
                string type = searchGuitar.Gettype();
                if ((type != null) && (!type.Equals("")) && (!type.Equals(guitar.Gettype())))
                    continue;

                string backWood = searchGuitar.GetbackWood();
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.GetbackWood())))
                    continue;

                string topWood = searchGuitar.GettopWood();
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.GettopWood())))
                    continue;
            }
            return null;
        }
    }
}

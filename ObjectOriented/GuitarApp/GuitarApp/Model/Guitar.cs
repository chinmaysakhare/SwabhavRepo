using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    class Guitar
    {
        private string SerialNumber, builder, model, type, backWood, topWood;
        private double price;

        public Guitar(string SerialNumber,double price,string builder,string model,string type,string backWood,string topWood)
        {
            this.SerialNumber = SerialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }
        public string GetSerialNumber()
        {
            return SerialNumber;
        }
        public double Getprice()
        {
            return price;
        }
        public string Getbuilder()
        {
            return builder;
        }
        public string Getmodel()
        {
            return model;
        }
        public string Gettype()
        {
            return type;
        }
        public string GetbackWood()
        {
            return backWood;
        }
        public string GettopWood()
        {
            return topWood;
        }

    }
}

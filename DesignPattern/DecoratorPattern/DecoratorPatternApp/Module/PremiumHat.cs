using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Module
{
    public class PremiumHat:IHat
    {
        private string _name = " Premium Hat";
        private double _price = 1000;
        private string _description = " This a Premium hat.Cost Rs. 1000/-\n";
        public string getName()
        {
            return _name;
        }
         public double getPrice()
        {
            return _price;
        }
        public string getDescription()
        {
            return _description;
        }
    }
}

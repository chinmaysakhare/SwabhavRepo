using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Module
{
    public class StandardHat:IHat
    {
        private string _name = " Standard Hat";
        private double _price = 500;
        private string _description = " This a Standard hat. Cost Rs. 500/-\n";
        public string getName()
        {
            return _name;
        }
        virtual public double getPrice()
        {
            return _price;
        }
        public string getDescription()
        {
            return _description;
        }
    }
}

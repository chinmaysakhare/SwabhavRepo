using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Module
{
    public class RibbonHat:IHat
    {
        private IHat hat;
        private string _name = " Ribbon";
        private double _price = 200;
        private string _description = "\n Ribbon is Added. Ribbon Cost Rs 200/-\n";

        public RibbonHat(IHat hat)
        {
            this.hat = hat;
        }
        public string getName()
        {
            string tempName = hat.getName();
            _name += tempName;
            return _name;
        }
        public double getPrice()
        {
            double tempPrice = hat.getPrice();
            _price += tempPrice;
            return _price;
        }
        public string getDescription()
        {
            string tempDescription = hat.getDescription();
            _description += tempDescription;
            return _description;
        }
    }
}

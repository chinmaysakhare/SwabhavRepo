using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternApp.Module
{
    public class GoldenHat:IHat
    {
        private IHat hat;
        private string _name = " Golden";
        private double _price = 400;
        private string _description = " Golden colour Added.Color cost Rs 400/- \n";

        public GoldenHat(IHat hat)
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

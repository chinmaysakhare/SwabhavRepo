using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemExternalLib;

namespace ShoppingCartClientApp
{
    public class HatToAdapter:IItem
    {
        private Hat hat;

        public HatToAdapter(Hat hat)
        {
            this.hat = hat;
        }
        public string itemName()
        {
            return hat.LongName;
        }
        public double itemPrice()
        {
            return hat.GetPrice;
        }
    }
}

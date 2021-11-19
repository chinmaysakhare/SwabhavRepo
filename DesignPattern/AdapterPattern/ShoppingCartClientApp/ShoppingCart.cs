using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ShoppingCartClientApp
{
    public class ShoppingCart
    {
        List<IItem> items = new List<IItem>();
        public void addItem(IItem i)
        {
            items.Add(i);
        }
        public void removeItem(IItem i)
        {
            items.Remove(i);
        }
        public double totalPrice()
        {
            double totalPrice = 0;
            foreach (var i in items)
            {
                totalPrice += i.itemPrice();
            }
            return totalPrice;
        }
        public List<IItem> GetList()
        {
            return items;
        }
    }
}

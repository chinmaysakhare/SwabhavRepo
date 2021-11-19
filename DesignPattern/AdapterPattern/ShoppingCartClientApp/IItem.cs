using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
    public interface IItem
    {
        string itemName();
        double itemPrice();
    }
}

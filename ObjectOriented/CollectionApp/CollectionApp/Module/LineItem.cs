using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionApp.Module
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _quantity;
        double totalPrice;
        double price;

        public LineItem(string productName, double price, int quantity)
        {
            _productName = productName;
            _price = price;
            _quantity = quantity;
        }
        public void BillAmt()
        {
            totalPrice = (_quantity * _price) + totalPrice;
            price = price + totalPrice;
        }
        public Double GetBillAmount { get {return price; }  }
        public double Total()
        {
            return price;
        }

        public string Name{ get {return _productName; }}
        public double Price { get { return _price; }  }
        public int Quantity { get {return _quantity; }  }
    }
}

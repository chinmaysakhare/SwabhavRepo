using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation
{
    class Invoice
    {
        private int _id;
        private string _description;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string description, double amount, float tax, float discount)
        {
            _id = id;
            _description = description;
            _amount = amount;
            _tax = tax;
            _discount = discount;
        }
        public double CalculateTax()
        {
            double calcTax = _amount * _tax; 
            return calcTax;
        }
        public double CalculateDiscount() 
        {
            double calDisc = _amount * _discount;
            return calDisc;
        }
        public double CalculateFinalAmount()
        {
            double finalAmt = _amount - CalculateDiscount() + CalculateTax();
            return finalAmt;
        }
        public int Id { get {return _id; }  }
        public string Description { get {return _description; }  }
        public double Amount { get {return _amount; }  }
        public float Tax { get {return _tax; }  }
        public float Discount { get {return _discount; }  }
        public void PrintDetails()
        {
            Console.WriteLine("ID : " + Id);
            Console.WriteLine(Description);
            Console.WriteLine("Initial Amount : " + Amount);
            Console.WriteLine("Tax : " + Tax * 100 + " %");
            Console.WriteLine("Discount : " + Discount * 100 + "%");
            Console.WriteLine("Tax Deductions : " + CalculateTax());
            Console.WriteLine("Discount Addition : " + CalculateDiscount());
            Console.WriteLine("Final Amount : : " + CalculateFinalAmount());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
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
            return Math.Round(calcTax,2);
        }
        public double CalculateDiscount()
        {
            double calDisc = _amount * _discount;
            return Math.Round(calDisc, 2);
        }
        public double CalculateFinalAmount()
        {
            double finalAmt = _amount - CalculateDiscount() + CalculateTax();
            return Math.Round(finalAmt, 2);
        }
        public int Id { get { return _id; } }
        public string Description { get { return _description; } }
        public double Amount { get { return _amount; } }
        public float Tax { get { return _tax; } }
        public float Discount { get { return _discount; } }

       
    }
}

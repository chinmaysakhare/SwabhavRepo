using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Module
{
    class FixedDeposit
    {
        public enum Festivals
        {
            Newyear, Diwali, Eid, Normal
        }
        private string _name;
        private double _amt;
        private int _duration;
        private Festivals _festivalType;

        public FixedDeposit(string name, double amt, int duration, Festivals festivalType)
        {
            _name = name;
            _amt = amt;
            _duration = duration;
            _festivalType = festivalType;
        }
        public double CalcRateOfIntrest()
        {
            double roi;
            if (_festivalType == Festivals.Newyear)
            {
                roi = 9;

            }
            else if (_festivalType == Festivals.Eid)
            {
                roi = 8.5;
            }
            else if (_festivalType == Festivals.Diwali)
                roi = 8;
            else
                roi = 7;

            return roi;
        }
        public double CalcSimpleIntrest()
        {
            double si = (_amt * CalcRateOfIntrest() * _duration)/100;
            return si;
        }
    }
}

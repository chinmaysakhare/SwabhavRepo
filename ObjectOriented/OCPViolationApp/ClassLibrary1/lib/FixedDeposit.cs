using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.Module
{
    class FixedDeposit
    {
        private string _name;
        private double _amt;
        private int _duration;
        private IFestivalPolicy _festivalPolicy;

        public FixedDeposit(string name, double amt, int duration, IFestivalPolicy festivalPolicy)
        {
            _name = name;
            _amt = amt;
            _duration = duration;
            _festivalPolicy = festivalPolicy;
        }
        public double CalcSimpleIntrest()
        {
            double si;
            si = (_festivalPolicy.CalcRateOfIntrest() * _amt * _duration) / 100;
            return si;
        }
    }
}

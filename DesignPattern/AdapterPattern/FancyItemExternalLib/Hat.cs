using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemExternalLib
{
    public class Hat
    {
        private string _shortName;
        private string _longName;
        private double _basePrice;
        private double _gst=0.08;
        public double GetPrice { get { return _basePrice; } }
        public string ShortName { get { return _shortName; }  }
        public string LongName { get { return _longName; } }

        public Hat(string shortName, string longName, double basePrice)
        {
            _shortName = shortName;
            _longName = longName;
            _basePrice = basePrice;
        }
    }
}

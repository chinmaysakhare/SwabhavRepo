using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Module
{
    public class CarInspection:ICarService
    {
        private double _cost=250;
        private string _description = "\n Car is inspected";
        public double getCost()
        {
            return _cost;
        }
        public string getDescription()
        {
            return _description;
        }
    }
}

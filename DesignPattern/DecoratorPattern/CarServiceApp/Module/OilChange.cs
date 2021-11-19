using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Module
{
    public class OilChange : ICarService
    {
        private ICarService _service;
        private double _cost = 1200;
        private string _description = "\n Oil Changed";

        public OilChange(ICarService service)
        {
            _service = service;
        }
        public double getCost()
        {
            double tempCost = _service.getCost();
            _cost += tempCost;
            return _cost;
        }
        public string getDescription()
        {
            string tempDescription = _service.getDescription();
            _description += tempDescription;
            return _description;
        }
    }
}

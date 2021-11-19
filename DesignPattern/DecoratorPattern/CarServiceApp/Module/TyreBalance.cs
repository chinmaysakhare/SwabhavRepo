using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Module
{
    public class TyreBalance:ICarService
    {
        private ICarService _service;
        private double _cost = 3000;
        private string _description = "\n Tyres Balanced";

        public TyreBalance(ICarService service)
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

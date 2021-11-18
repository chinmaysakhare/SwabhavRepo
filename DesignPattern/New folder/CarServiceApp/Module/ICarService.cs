using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Module
{
    public interface ICarService
    {
        double getCost();
        string getDescription();
    }
}

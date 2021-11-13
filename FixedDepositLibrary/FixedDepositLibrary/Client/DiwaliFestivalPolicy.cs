using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FixedDepositLibrary.Lib;

namespace FixedDepositLibrary.Client
{
    class DiwaliFestivalPolicy: IFestivalPolicy
    {
        public double CalcRateOfIntrest()
        {
            return 8;
        }
    }
}

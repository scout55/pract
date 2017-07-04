using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
    public class CosCalc : IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Cos(Arg);
        }
    }
}

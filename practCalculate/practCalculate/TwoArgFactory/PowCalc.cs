using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
    public class PowCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg,double secondArg)
        {
            return Math.Pow(firstArg,secondArg);
        }
    }
}

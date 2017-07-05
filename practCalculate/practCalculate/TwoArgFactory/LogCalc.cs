using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
    public class LogCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            double temp = Math.Log(secondArg) / Math.Log(firstArg);
            return temp;
        }
    }
}

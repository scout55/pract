using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
    public class CtgCalc:IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            double temp = Math.Tan(Arg);
            return Math.Pow(temp,-1);
        }
    }
}

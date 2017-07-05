using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
{
    public class ReverseCalc:IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return -Arg;
        }
    }
}

using System;
using System.Windows.Forms;

namespace practCalculate.TwoArg
{
    /// <summary>
    /// Class for calculate division.
    /// </summary>
    public class DivisionCalc : ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
                if (secondArg == 0)
                {
                    throw new Exception("Second argument is bad.");
                }
                double result = firstArg / secondArg;
                return result;
        }
    }
}

using System;

namespace practCalculate.TwoArg
{
    /// <summary>
    /// Class for calculate power A of B.
    /// </summary>
    public class PowCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg,double secondArg)
        {
            return Math.Pow(firstArg,secondArg);
        }
    }
}

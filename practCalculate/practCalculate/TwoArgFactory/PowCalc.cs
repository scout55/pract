using System;

namespace practCalculate.TwoArgFactory
{
    public class PowCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg,double secondArg)
        {
            return Math.Pow(firstArg,secondArg);
        }
    }
}

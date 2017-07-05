using System;

namespace practCalculate.OneArgFactory
{
    public class ExpCalc : IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Exp(Arg);
        }
    }
}

using System;

namespace practCalculate.OneArgFactory
{
    public class CosCalc : IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Cos(Arg);
        }
    }
}

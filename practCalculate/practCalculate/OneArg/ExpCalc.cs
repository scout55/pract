using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate exp(x).
    /// </summary>
    public class ExpCalc : IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Exp(Arg);
        }
    }
}

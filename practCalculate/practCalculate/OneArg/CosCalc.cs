using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate cos(x).
    /// </summary>
    public class CosCalc : IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Cos(Arg);
        }
    }
}

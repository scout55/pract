using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate ln(x).
    /// </summary>
    public class LnCalc:IOneArgCalc
    {
        public double Calculate(double arg)
        {
            if (arg <0)
            {
                throw new Exception("Argument is bad.");

            }
            return Math.Log(arg);
        }
    }
}

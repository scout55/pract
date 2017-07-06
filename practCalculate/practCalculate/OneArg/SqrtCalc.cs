using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate sqrt(x).
    /// </summary>
    public class SqrtCalc : IOneArgCalc
    {
        public double Calculate(double arg)
        {
            if (arg <0)
            {
                throw new Exception("Argument is bad.");

            }
            return Math.Sqrt(arg);
        }
    }
}

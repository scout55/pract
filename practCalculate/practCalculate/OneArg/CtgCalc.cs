using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate tg(x).
    /// </summary>
    public class CtgCalc : IOneArgCalc
    {
        public double Calculate(double arg)
        {
            if (arg == 0 || arg == Math.PI)
            {
                throw new Exception("Argument is bad.");

            }
            double temp = Math.Tan(arg);
            return Math.Pow(temp, -1);

        }
    }
}

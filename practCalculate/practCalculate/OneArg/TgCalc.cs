using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate tg(x).
    /// </summary>
    public class TgCalc:IOneArgCalc
    {
        public double Calculate(double arg)
        {
            if (arg == Math.PI / 2 || arg == 3*Math.PI/2)
            {
                throw new Exception("Argument is bad.");

            }
            return Math.Tan(arg);
        }
    }
}

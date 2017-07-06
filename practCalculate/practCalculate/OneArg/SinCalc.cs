using System;

namespace practCalculate.OneArg
{
    /// <summary>
    /// Class for calculate Sin(x).
    /// </summary>
   public class SinCalc:IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Sin(Arg);
        }
    }
}

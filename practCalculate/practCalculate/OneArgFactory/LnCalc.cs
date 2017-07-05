using System;

namespace practCalculate.OneArgFactory
{
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

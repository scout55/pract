using System;

namespace practCalculate.OneArgFactory
{
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

using System;

namespace practCalculate.TwoArgFactory
{
    public class LogCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg, double secondArg)
        {
            if (firstArg < 0 || firstArg == 1)
            {
                throw new Exception("First argument is bad.");

            }
            if (secondArg < 0)
            {
                throw new Exception("Second argument is bad.");

            }
            double temp = Math.Log(secondArg) / Math.Log(firstArg);
            return temp;
        }
    }
}

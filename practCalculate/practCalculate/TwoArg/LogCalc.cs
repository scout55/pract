using System;

namespace practCalculate.TwoArg
{
    /// <summary>
    /// Class for calculate LOGa(b).
    /// </summary>
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

            return Math.Log(firstArg) / Math.Log(secondArg);
        }
    }
}

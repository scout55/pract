namespace practCalculate.TwoArg
{
    /// <summary>
    /// Class for calculate addition.
    /// </summary>
   public class AdditionCalc:ITwoArgCalc
    {
        public double Calculate(double firstArg,double secondArg)
        {
            double result;
            result = firstArg + secondArg;
            return result;
        }

    }
}

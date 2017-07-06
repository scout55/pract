namespace practCalculate.TwoArg
{
    /// <summary>
    /// Class for calculate subtraction.
    /// </summary>
   public class SubstractionCalc : ITwoArgCalc
    {
       public double Calculate(double firstArg, double secondArg)
        {
            double result;
            result = firstArg - secondArg;
            return result;
        }
    }
}

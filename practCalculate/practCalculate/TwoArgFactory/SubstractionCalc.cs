namespace practCalculate.TwoArgFactory
{
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

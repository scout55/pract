using System;

namespace practCalculate.OneArgFactory
{
   public class SinCalc:IOneArgCalc
    {
        public double Calculate(double Arg)
        {
            return Math.Sin(Arg);
        }
    }
}

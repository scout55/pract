using System;

namespace practCalculate.TwoArgFactory
{
    public  class TwoArgumentsFactory
    {
        public static ITwoArgCalc createCalculator(string calcName)
        {
            switch (calcName)
            {
                case "btnAdd":
                    return new AdditionCalc();
                case "btnSub":
                    return new SubstractionCalc();
                case "btnMult":
                    return new MultiplyCalc();
                case "btnDiv":
                    return new DivisionCalc();
                case "btnPow":
                    return new PowCalc();
                case "btnLog":
                    return new LogCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

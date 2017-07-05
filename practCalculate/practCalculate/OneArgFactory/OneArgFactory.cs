using System;

namespace practCalculate.OneArgFactory
{

    public class OneArgFactory
    {
        public static IOneArgCalc createCalculator(string calcName)
        {
            switch (calcName)
            {
                case "btnSin":
                    return new SinCalc();
                case "btnCos":
                    return new CosCalc();
                case "btnExp":
                    return new ExpCalc();
                case "btnSqrt":
                    return new SqrtCalc();
                case "btnTg":
                    return new TgCalc();
                case "btnCtg":
                    return new CtgCalc();
                case "btnLn":
                    return new LnCalc();
                case "btnReverse":
                    return new ReverseCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

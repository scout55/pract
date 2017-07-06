using System;

namespace practCalculate.OneArg
{
    public class OneArgFactory
    {
        /// <summary>
        /// A factory that instantiates a class by the name of a button.
        /// </summary>
        /// <param name="calcName"> <see cref="string"/> value here.</param>
        /// <returns> Return the Instance of a class. </returns>
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

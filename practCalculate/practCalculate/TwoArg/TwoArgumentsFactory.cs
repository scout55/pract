using System;

namespace practCalculate.TwoArg
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// A factory that instantiates a class by the name of a button.
        /// </summary>
        /// <param name="calcName">
        ///  <see cref="string"/> value here.</param>
        /// <returns> Return the instance of a class. </returns>

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

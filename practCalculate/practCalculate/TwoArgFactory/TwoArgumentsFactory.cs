using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practCalculate
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

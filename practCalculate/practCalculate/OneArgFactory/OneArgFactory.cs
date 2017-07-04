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
                case "button5":
                    return new SinCalc();
                case "button6":
                    return new CosCalc();
                case "button7":
                    return new ExpCalc();
                case "button8":
                    return new SqrtCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

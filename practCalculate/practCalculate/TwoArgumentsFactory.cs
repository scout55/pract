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
                case "button1":
                    return new AdditionCalc();
                case "button2":
                    return new SubstractionCalc();
                case "button3":
                    return new MultiplyCalc();
                case "button4":
                    return new DivisionCalc();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

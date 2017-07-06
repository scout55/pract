using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using practCalculate.TwoArg;

namespace practCalculate.Tests.TwoArgTests
{
    [TestFixture]
    public class AdditionCalcTests
    {
        [TestCase(10, 1, 11)]
        [TestCase(0, 2, 2)]
        [TestCase(15, 15, 30)]
        public void CalculateTest(double firstArg, double secondArg, double expected)
        {

            var calculator = new AdditionCalc();
            var result = calculator.Calculate(firstArg, secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }

}

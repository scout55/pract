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
    public class MultiplyCalcTests
    {
        [TestCase(10, 1, 10)]
        [TestCase(0, 2, 0)]
        [TestCase(2, 2, 4)]
        public void CalculateTest(double firstArg, double secondArg, double expected)
        {

            var calculator = new MultiplyCalc();
            var result = calculator.Calculate(firstArg, secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }

}


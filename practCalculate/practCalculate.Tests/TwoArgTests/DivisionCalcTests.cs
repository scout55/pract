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
    public class DivisionCalcTests
    {
        [TestCase(10, 1, 10)]
        [TestCase(0, 2, 0)]
        [TestCase(15, 3, 5)]
        public void CalculateTest(double firstArg, double secondArg, double expected)
        {

            var calculator = new DivisionCalc();
            var result = calculator.Calculate(firstArg, secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
        [TestCase(-2, 0)]
        public void ExceptionTests(double firstArg, double secondArg)
        {
            var calculator = new DivisionCalc();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArg, secondArg));
        }
    }

}


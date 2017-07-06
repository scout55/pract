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
    public class LogCalcTests
    {
        [TestCase(2, 8, 3)]
        [TestCase(3, 9, 2)]
        [TestCase(4, 16, 2)]
        public void CalculateTest(double firstArg, double secondArg, double expected)
        {

            var calculator = new LogCalc();
            var result = calculator.Calculate(firstArg, secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
        [TestCase(-2,10)]
        [TestCase(1,2)]
        public void ExceptionTests(double firstArg,double secondArg)
        {
            var calculator = new LogCalc();
            Assert.Throws<Exception>(() => calculator.Calculate(firstArg,secondArg));
        }
    }

}

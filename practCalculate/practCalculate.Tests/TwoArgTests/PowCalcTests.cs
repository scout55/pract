using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace practCalculate.Tests.TwoArgTests
{
    [TestFixture]
    public class PowCalcTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 0)]
        [TestCase(0, 0, 1)]
        public void CalculateTest(double firstArg, double secondArg, double expected)
        {

            var calculator = new PowCalc();
            var result = calculator.Calculate(firstArg, secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }

}

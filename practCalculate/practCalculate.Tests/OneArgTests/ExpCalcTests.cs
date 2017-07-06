using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using practCalculate.OneArg;

namespace practCalculate.Tests.OneArgTests
{

    [TestFixture]
    public class ExpCalcTests
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.7182)]
        [TestCase(2, 7.3890)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new ExpCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }
}


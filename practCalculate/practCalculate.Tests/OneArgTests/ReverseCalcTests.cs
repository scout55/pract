using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace practCalculate.Tests.OneArgTests
{

    [TestFixture]
    public class ReverseCalcTests
    {
        [TestCase(-1, 1)]
        [TestCase(2, -2)]
        [TestCase(-5, 5)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new ReverseCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected);
        }
    }
}


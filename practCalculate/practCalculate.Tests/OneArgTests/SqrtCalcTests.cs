using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace practCalculate.Tests.OneArgTests
{

    [TestFixture]
    public class SqrtCalcTests
    {
        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(16, 4)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new SqrtCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }
}

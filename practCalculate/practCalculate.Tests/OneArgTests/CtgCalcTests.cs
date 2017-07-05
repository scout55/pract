using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace practCalculate.Tests.OneArgTests
{

    [TestFixture]
    public class CtgCalcTests
    {
        [TestCase(1, 0.6420)]
        [TestCase(90, -0.5012)]
        [TestCase(45, 0.6173)]
        public void CalculateTest(double arg, double expected)
        {
            var calculator = new CtgCalc();
            var result = calculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }
}

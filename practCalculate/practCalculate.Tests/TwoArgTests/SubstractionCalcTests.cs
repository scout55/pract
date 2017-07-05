using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using practCalculate.TwoArgFactory;

namespace practCalculate.Tests.TwoArgTests
{
    [TestFixture]
    public class SubstractionCalcTests
    {
        [TestCase(10, 1,9)]
        [TestCase(0, 2,-2)]
        [TestCase(15, 15,0)]
        public void CalculateTest(double firstArg,double secondArg, double expected)
        {

            var calculator = new SubstractionCalc();
            var result = calculator.Calculate(firstArg,secondArg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }

}

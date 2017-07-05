using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using practCalculate.OneArgFactory;

namespace practCalculate.Tests.OneArgTests
{
    [TestFixture]
    public class CosCalcTests
    {
        [TestCase(0, 1)]
        [TestCase(90, -0.4480)]
        [TestCase(45, 0.5253)]
        public void CalculateTest(double arg,double expected)
        {

            var cosCalculator = new CosCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected,0.0001);
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace practCalculate.Tests.OneArgTests
{
   
    [TestFixture]
    public class SinCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(90, 0.8939)]
        [TestCase(45, 0.8509)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new SinCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using practCalculate.OneArg;

namespace practCalculate.Tests.OneArgTests
{

    [TestFixture]
    public class LnCalcTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.6931)]
        [TestCase(3, 1.0986)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new LnCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }

        [TestCase(-2)]
        public void ExceptionTests(double arg)
        {
            var calculator = new LnCalc();
            Assert.Throws<Exception>(() => calculator.Calculate(arg));
        }
    }
}


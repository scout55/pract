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
    public class TgCalcTests
    {
        [TestCase(0, 0)]
        [TestCase(90, -1.9952)]
        [TestCase(45, 1.6197)]
        public void CalculateTest(double arg, double expected)
        {
            var cosCalculator = new TgCalc();
            var result = cosCalculator.Calculate(arg);
            Assert.AreEqual(result, expected, 0.0001);
        }
        [TestCase(Math.PI/2)]
        [TestCase(3*Math.PI/2)]
        public void ExceptionTests(double arg)
        {
            var calculator = new TgCalc();
            Assert.Throws<Exception>(() => calculator.Calculate(arg));
        }
    }
}

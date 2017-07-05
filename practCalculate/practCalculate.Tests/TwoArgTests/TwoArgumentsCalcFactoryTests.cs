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
    public class TwoArgumentsCalcFactoryTests
    {
        [TestCase("btnAdd", typeof(AdditionCalc))]
        [TestCase("btnSub", typeof(SubstractionCalc))]
        [TestCase("btnMult", typeof(MultiplyCalc))]
        [TestCase("btnDiv", typeof(DivisionCalc))]
        [TestCase("btnPow", typeof(PowCalc))]
        [TestCase("btnLog", typeof(LogCalc))]
        public void CalculateTest(string arg, Type type)
        {
            var calculator = TwoArgumentsFactory.createCalculator(arg);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

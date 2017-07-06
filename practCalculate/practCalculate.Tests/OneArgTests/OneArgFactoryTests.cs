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
    public class OneArgFactoryTests
    {
        [TestCase("btnSin", typeof(SinCalc))]
        [TestCase("btnCos", typeof(CosCalc))]
        [TestCase("btnSqrt", typeof(SqrtCalc))]
        [TestCase("btnTg", typeof(TgCalc))]
        [TestCase("btnCtg", typeof(CtgCalc))]
        [TestCase("btnExp", typeof(ExpCalc))]
        [TestCase("btnLn", typeof(LnCalc))]
        [TestCase("btnReverse", typeof(ReverseCalc))]
        public void CalculateTest(string arg, Type type)
        {
            var calculator = OneArgFactory.createCalculator(arg);
            Assert.IsInstanceOf(type, calculator);
        }

        [TestCase("Btnasdasd")]
        public void ExceptionTest(string arg)
        {
            Assert.Throws<Exception>(() => OneArgFactory.createCalculator(arg));
        }

}
}

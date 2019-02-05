using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandtestingCalculator;
using NUnit.Framework;

namespace TestCalculator.Test.Unit
{
    class Calculator_Subtract_TestUnit
    {
        [TestFixture]
        public class Calculator_Substract_TestUnit
        {
            private Calculator uut;

            [SetUp]
            public void SetUp()
            {
                uut = new Calculator();
            }

            //[Test]
            //public void Substract_AAndB_ResultCorrect()
            //{
            //     = -9.74;
            //    _uut.B = 5.32;

            //    double result = _uut.Substract(_uut.A, _uut.B);

            //    Assert.That(result, Is.EqualTo(-15.06).Within(0.01)); //fastsætter en acceptable afvigelse
            //}

            [TestCase(1, 2, -1)]
            [TestCase(1.5, 1.5, 0)]
            [TestCase(2, 1.7, 0.3)]
            public void Substract_TwoPositiveNumbers_ResultCorrect(double a, double b, double expectedResult)
            {
                double result = uut.Subtract(a, b);
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
            }
            [TestCase(-1, -2, 1)]
            [TestCase(-1.5, -1.5, 0)]
            [TestCase(-1.5, -1.7, 0.2)]
            public void Add_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
            {
                double result = uut.Add(a, b);
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
            }
            [TestCase(1, -2, 3)]
            [TestCase(1.5, -1.5, 0)]
            [TestCase(1.5, -1.7, 0.2)]
            public void Add_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
            {
                double result = uut.Add(a, b);
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
            }
            [TestCase(-1, 2, -3)]
            [TestCase(-1.5, 1.5, -3)]
            [TestCase(-1.5, 1.7, -3.2)]
            public void Add_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
            {
                double result = uut.Add(a, b);
                Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
            }
        }
    }
}

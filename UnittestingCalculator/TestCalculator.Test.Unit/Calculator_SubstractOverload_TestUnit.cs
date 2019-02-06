using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandtestingCalculator;
using NUnit.Framework;

namespace TestCalculator.Test.Unit
{
    [TestFixture]
    public class Calculator_SubstractOverload_TestUnit
    {
        private Calculator uut;
        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        //[Test]
        //public void Subtract_AAndB_ResultCorrect()
        //{
        //    double a = 5;
        //    double b = 11;

        //    double result = uut.Subtract(a, b);

        //    Assert.That(result, Is.EqualTo(-6).Within(0.01)); //fastsætter en acceptable afvigelse
        //}

        [TestCase(7, 8, -1)]
        [TestCase(9, 9, 0)]
        [TestCase(15, 14.5, 0.5)]
        public void Subtract_TwoPositiveNumbers_ResultCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
        [TestCase(-5, -6, 1)]
        [TestCase(-10, -5, -5)]
        [TestCase(-3.75, -3.75, 0)]
        public void Subtract_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
        [TestCase(4.5, -2, 6.5)]
        [TestCase(6.75, -2.75, 9.5)]
        [TestCase(3, -2, 5)]
        public void Subtract_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
        [TestCase(-7, 9, -16)]
        [TestCase(-3.45, 2.35, -5.8)]
        [TestCase(-1.5, 1.7, -3.2)]
        public void Subtract_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(5, 0, 5)]
        [TestCase(7, 0, 7)]
        public void Subtract_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(-5, 0, -5)]
        [TestCase(-7, 0, -7)]
        public void Subtract_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(0, 0, 0)]
        public void Subtract_Zero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Substract(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}



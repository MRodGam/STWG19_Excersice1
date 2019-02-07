using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HandtestingCalculator;

namespace TestCalculator.Test.Unit
{
    class Calculator_MultiplyOverload_TestUnit
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [TestCase(2, 2, 4)]
        [TestCase(5, 5, 25)]
        [TestCase(3.6, 7.2, 25.920)]
        public void Multiply_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }

        [TestCase(-2, -2, 4)]
        [TestCase(-5, -5, 25)]
        [TestCase(-3.6, -7.2, 25.920)]
        public void Multiply_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(2, -2, -4)]
        [TestCase(5, -5, -25)]
        [TestCase(3.6, -7.2, -25.920)]
        public void Multiply_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(-2, 2, -4)]
        [TestCase(-5, 5, -25)]
        [TestCase(-3.6, 7.2, -25.920)]
        public void Multiply_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(1, 0, 0)]
        [TestCase(1.5, 0, 0)]
        public void Multiply_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(-1, 0, 0)]
        [TestCase(-1.5, 0, 0)]
        public void Multiply_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(0, 0, 0)]
        public void Multiply_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

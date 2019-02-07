using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HandtestingCalculator;

namespace TestCalculator.Test.Unit
{
    [TestFixture]
    public class Calculator_Add_TestUnit
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [TestCase(1, 2, 3)]
        [TestCase(1.5, 1.5, 3)]         
        [TestCase(1.5, 1.7, 3.2)]
        public void Add_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }

        [TestCase(-1, -2, -3)]
        [TestCase(-1.5, -1.5, -3)]         
        [TestCase(-1.5, -1.7, -3.2)]
        public void Add_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(1, -2, -1)]
        [TestCase(1.5, -1.5, 0)]         
        [TestCase(1.5, -1.7, -0.2)]
        public void Add_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(-1, 2, 1)]
        [TestCase(-1.5, 1.5, 0)]         
        [TestCase(-1.5, 1.7, 0.2)]
        public void Add_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(1, 0, 1)]
        [TestCase(1.5, 0, 1.5)]         
        public void Add_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(-1, 0, -1)]
        [TestCase(-1.5, 0, -1.5)]         
        public void Add_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        [TestCase(0, 0, 0)]         
        public void Add_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

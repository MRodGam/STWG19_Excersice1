using System;
using NUnit.Framework;
using HandtestingCalculator;

namespace HandtestingCalculator.Test.Unit
{
    [TestFixture]
    public class CalculatorAdd
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [TestCase(1, 2, 3)]
        public void Add_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}

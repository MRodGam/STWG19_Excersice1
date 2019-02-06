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
    class Calculator_DivideOverload_TestUnit
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }
        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere to positive tal, af forskellige typer
        [TestCase(2, 2, 1)]
        [TestCase(5, 2.5, 2)]
        [TestCase(3.6, 7.2, 0.5)]
        public void Divide_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere to negtive tal, af forskellige typer
        [TestCase(-2, -2, 1)]
        [TestCase(-5, -2.5, 2)]
        [TestCase(-3.6, -7.2, 0.5)]
        public void Divide_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }


        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere et positivt tal og et negativt
        [TestCase(2, -2, -1)]
        [TestCase(5, -2.5, -2)]
        [TestCase(3.6, -7.2, -0.5)]
        public void Divide_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere et negativt og et positivt
        [TestCase(-2, 2, -1)]
        [TestCase(-5, 2.5, -2)]
        [TestCase(-3.6, 7.2, -0.5)]
        public void Divide_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere et positivt tal med 0
        [TestCase(1, 0, 1)]
        [TestCase(1.5, 0, 1.5)]
        public void Divide_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere et negativt tal med 0
        [TestCase(-1, 0, -1)]
        [TestCase(-1.5, 0, -1.5)]
        public void Divide_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at dividere 0 med 0
        [TestCase(0, 0, 0)]
        public void Divide_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Divide(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

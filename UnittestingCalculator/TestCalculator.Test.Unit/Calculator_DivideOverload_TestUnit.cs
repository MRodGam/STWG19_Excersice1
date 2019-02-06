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
        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange to positive tal, af forskellige typer
        [TestCase(2, 2, 1)]
        [TestCase(5, 2.5, 2)]
        [TestCase(3.6, 7.2, 25.920)]
        public void Multiply_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange to negtive tal, af forskellige typer
        [TestCase(-2, -2, 4)]
        [TestCase(-5, -5, 25)]
        [TestCase(-3.6, -7.2, 25.920)]
        public void Multiply_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }


        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange et positivt tal og et negativt
        [TestCase(2, -2, -4)]
        [TestCase(5, -5, -25)]
        [TestCase(3.6, -7.2, -25.920)]
        public void Multiply_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange et negativt og et positivt
        [TestCase(-2, 2, -4)]
        [TestCase(-5, 5, -25)]
        [TestCase(-3.6, 7.2, -25.920)]
        public void Multiply_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange et positivt tal med 0
        [TestCase(1, 0, 0)]
        [TestCase(1.5, 0, 0)]
        public void Multiply_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange et negativt tal med 0
        [TestCase(-1, 0, 0)]
        [TestCase(-1.5, 0, 0)]
        public void Multiply_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at gange 0 med 0
        [TestCase(0, 0, 0)]
        public void Multiply_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Multiply(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

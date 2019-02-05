using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using HandtestingCalculator;

namespace TestCalculator.Test.Unit
{
    [TestFixture]
    class Calcualtor_AddOverload_TestUnit
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }


        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere to positive tal, af forskellige typer
        [TestCase(1, 2, 3)]
        [TestCase(1.5, 1.5, 3)]
        [TestCase(1.5, 1.7, 3.2)]
        public void Add_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }


        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere to negtive tal, af forskellige typer
        [TestCase(-1, -2, -3)]
        [TestCase(-1.5, -1.5, -3)]
        [TestCase(-1.5, -1.7, -3.2)]
        public void Add_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); 
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at  summere et positivt tal og et negativt
        [TestCase(1, -2, -1)]
        [TestCase(1.5, -1.5, 0)]
        [TestCase(1.5, -1.7, -0.2)]
        public void Add_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere et negativt og et positivt
        [TestCase(-1, 2, 1)]
        [TestCase(-1.5, 1.5, 0)]
        [TestCase(-1.5, 1.7, 0.2)]
        public void Add_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere et positivt tal med 0
        [TestCase(1, 0, 1)]
        [TestCase(1.5, 0, 1.5)]
        public void Add_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere et negativt tal med 0
        [TestCase(-1, 0, -1)]
        [TestCase(-1.5, 0, -1.5)]
        public void Add_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere 0 med 0
        [TestCase(0, 0, 0)]
        public void Add_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Add(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

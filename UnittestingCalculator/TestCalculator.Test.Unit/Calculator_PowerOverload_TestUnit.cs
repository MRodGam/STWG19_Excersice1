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
    class Calculator_PowerOverload_TestUnit
    {
        private Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at ¨tage potensen af to positive tal, af forskellige typer
        [TestCase(1, 2, 1)]
        [TestCase(1.5, 1.5, 1.837)]
        [TestCase(1.5, 10, 57.665)]
        public void Power_TwoPositiveNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01)); // Denne within angiver graden af decimaltal man betragter. I dette tilfælde er det inden for to decimaler.
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at tage potensen af to negtive tal, af forskellige typer
        [TestCase(-1, -2, 1)]
        // [TestCase(-1.5, -10.5, 0.544)] Givet et imaginært tal
        [TestCase(-1.5, -10, 0.017)]
        public void Power_TwoNegativeNumbers_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at tage potensen af et positivt tal og et negativt
        [TestCase(1, -2, 1)]
        [TestCase(1.5, -1.5, 0.544)]
        [TestCase(1.5, -10, 0.017)]
        public void Power_OnePositiveOneNegativeNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            double result = uut.Power(a, b);
            Assert.That(result, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at tage potensen af et  et negativt og et positivt
        [TestCase(-1, 2, 1)]
        [TestCase(-1.5, 10, 57.665)]
        public void Power_OneNegativeOnePositiveNumber_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at tage potesen et positivt tal med 0
        [TestCase(1, 0, 1)]
        [TestCase(1.5, 0, 1)]
        public void Power_OnePositiveNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at tage potensen et negativt tal med 0
        [TestCase(-1, 0, 1)]
        [TestCase(-1.5, 0, 1)]
        public void Power_OneNegativeNumberZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }

        // Jeg tester med brug af testcases, hvorvidt metoden er er i stand til at summere 0 med 0
        [TestCase(0, 0, 1)]
        public void Power_ZeroToZero_OutputIsCorrect(double a, double b, double expectedResult)
        {
            uut.Accumulator = a;
            uut.Power(b);
            Assert.That(uut.Accumulator, Is.EqualTo(expectedResult).Within(0.01));
        }
    }
}

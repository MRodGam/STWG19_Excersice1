using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandtestingCalculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Add(double addend)
        {
            Accumulator = Accumulator + addend;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }

        public double Substract(double substractor)
        {
            Accumulator = Accumulator - substractor;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Ugyldig værdi. Der kan ikke divideres med 0.");  // Bør være en exception.
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public double Divide (double divisor)
        {
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            return result;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;

        }

    }
}

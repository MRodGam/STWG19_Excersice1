using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandtestingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            // Håndtest ved brug af debugging sat i return-linjen af hver metode



            // Test 1. To positive tal summeres. 
            // Forventet resultat 1+2 = 3;
            calculator.Add(1, 2);

            // Test 2. Et positivt og et negativt tal summeres
            // Forventet resultat 1+(-2) = -1;
            calculator.Add(1, -2);

            // Test 3. To negative tal summeres
            // Forventet resultat (-1)+(-2) = -3;
            calculator.Add(-1, -2);

            // Test 4. Et positivt tal summeres med 0
            // Forventet resultat 1+0 = 1;
            calculator.Add(1, 0);

            // Test 5. Et negativt  tal summeres med 0
            // Forventet resultat -1+0 = -1;
            calculator.Add(-1, 0);



            // Test 1. To positive tal fratrækkes. 
            // Forventet resultat 2-1 = 1;
            calculator.Subtract(2, 1);

            // Test 2. To positive tal fratrækkes. 
            // Forventet resultat 1-2 = -1;
            calculator.Subtract(1, 2);

            // Test 3. Et positivt og et negativt tal fratrækkes
            // Forventet resultat 1-(-2) = 3;
            calculator.Subtract(1, -2);

            // Test 4. Et positivt og et negativt tal fratrækkes
            // Forventet resultat -1-2 = -3;
            calculator.Subtract(-1, 2);

            // Test 5. To negative tal fratrækkes
            // Forventet resultat (-1)-(-2) = 1;
            calculator.Subtract(-1, -2);

            // Test 6. Et positivt tal fratrækkes 0
            // Forventet resultat 1-0 = 1;
            calculator.Subtract(1, 0);

            // Test 6. Et negativt tal fratrækkes 0
            // Forventet resultat -1-0 = -1;
            calculator.Subtract(-1, 0);




            // Test 1. To positive tal multipliceres. 
            // Forventet resultat 1*2 = 2;
            calculator.Multiply(1, 2);

            // Test 2. Et positivt og et negativt tal multipliceres
            // Forventet resultat 1*(-2) = -2;
            calculator.Multiply(1, -2);

            // Test 3. To negative tal multipliceres
            // Forventet resultat (-1)*(-2) = -2;
            calculator.Multiply(-1, -2);

            // Test 4. Et positivt tal multipliceret med 0
            // Forventet resultat 1*0 = 0
            calculator.Multiply(1, 0);

            // Test 4. Et negativt tal multipliceret med 0
            // Forventet resultat -1*0 = 0
            calculator.Multiply(-1, 0);




            // Test 1. To positive tal i potens
            // Forventet resultat 2^1 = 2;
            calculator.Power(2, 1);

            // Test 2. Et positivt tal i potens
            // Forventet resultat -2^1 = -2;
            calculator.Power(-2, 1);

            // Test 3. To negative tal i potens
            // Forventet resultat -2^-1 = -0.5;
            calculator.Power(-2, 1);

            // Test 4. Nul i potens
            // Forventet resultat 2^0 = 0;
            calculator.Power(2, 0);

            // Test 5. Nul som rod
            // Forventet resultat 0^2 = 0;
            calculator.Power(0,2);
        }
    }
}

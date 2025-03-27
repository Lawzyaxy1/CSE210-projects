using System;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create fractions using the three constructors
            Fraction fraction1 = new Fraction(); // 1/1
            Fraction fraction2 = new Fraction(6); // 6/1
            Fraction fraction3 = new Fraction(6, 7); // 6/7
            Fraction fraction4 = new Fraction(1, 3); // 1/3

            // Display the fraction and decimal representations
            Console.WriteLine(fraction1.GetFractionString()); // Output: 1/1
            Console.WriteLine(fraction1.GetDecimalValue());  // Output: 1

            Console.WriteLine(fraction2.GetFractionString()); // Output: 6/1
            Console.WriteLine(fraction2.GetDecimalValue());  // Output: 6

            Console.WriteLine(fraction3.GetFractionString()); // Output: 6/7
            Console.WriteLine(fraction3.GetDecimalValue());  // Output: 0.8571428571428571

            Console.WriteLine(fraction4.GetFractionString()); // Output: 1/3
            Console.WriteLine(fraction4.GetDecimalValue());  // Output: 0.3333333333333333
        }
    }
}

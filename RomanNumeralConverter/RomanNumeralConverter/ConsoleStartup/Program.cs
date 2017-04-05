using System;

namespace RomanNumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a Roman Numeral to convert:");
                string romanNumeral = Console.ReadLine();

                int result = RomanNumeralToArabic.Convert(romanNumeral);

                Console.WriteLine($"Result: {result}");

                Console.ReadLine();
            }
        }
    }
}

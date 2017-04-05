using System;

namespace RomanNumeral
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Roman Numeral to convert:");
            string romanNumeral = Console.ReadLine();

            int result = RomanNumeralToArabic.Convert(romanNumeral);

            Console.WriteLine($"Result: {result}");

            Console.ReadLine();
        }
    }
}

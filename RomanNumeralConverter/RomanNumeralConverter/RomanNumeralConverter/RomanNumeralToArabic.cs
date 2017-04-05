using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RomanNumeral
{
    public class RomanNumeralToArabic
    {
        static char[] numerals = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        static int[] decimals = { 1, 5, 10, 50, 100, 500, 1000 };

        public static int Convert(String s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("Input cannot be null");
            }
            s = s.ToUpper();

            Regex regex = new Regex("(I{0,3}V{0,3}X{0,3}L{0,3}C{0,3}D{0,3}M{0,3})+");

            if (s.Length == 0 || !(regex.Match(s).ToString().Equals(s)))
            {
                throw new ArgumentException("Invalid roman numeral");
            }

            return Convert(s, numerals.Length - 1);
        }

        public static int Convert(String input, int lookat)
        {
            if (input.Length == 0) return 0;

            int index = input.IndexOf(numerals[lookat]);

            if (index != -1)
            {
                if (index != 0)
                {
                    return decimals[lookat] - Convert(input.Substring(0, index), lookat) + Convert(input.Substring(index + 1), lookat);
                }
                else return decimals[lookat] + Convert(input.Substring(1), lookat);
            }
            else return Convert(input, lookat - 1);
        }
    }
}

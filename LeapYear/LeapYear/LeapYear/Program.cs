using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        private const string requestInput = "Please enter year to check:";

        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine(requestInput);

            while ((input = Console.ReadLine()) != null)
            {
                Console.WriteLine(LeapYearTest.isLeapYear(int.Parse(input)));
                Console.WriteLine(requestInput);
            }

        }
    }
}

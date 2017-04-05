using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 5 numbers:");
            string[] numbers = Console.ReadLine().Split(' ');

            for (int i = numbers.Length - 1; i >= 0;  i--)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.ReadLine();
        }
    }
}

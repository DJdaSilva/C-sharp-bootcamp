using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number?");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while(number > 0)
            {
                int even = number % 2;
                switch (even)
                {
                    case 0:
                        {
                            Console.WriteLine($"Adding {number}");
                            sum += number;
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine($"Not adding {number}");
                            break;
                        }
                }

                number--;
            }

            Console.WriteLine($"Total is {sum}");
            Console.ReadLine();
        }
    }
}

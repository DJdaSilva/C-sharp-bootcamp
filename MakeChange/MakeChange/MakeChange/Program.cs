using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeChange
{
    class Program
    {
        static int[] denominations = { 1, 2, 5, 20, 50, 100 };

        static void Main(string[] args)
        {
            Console.WriteLine("Amount due:");
            int amountDue = int.Parse(Console.ReadLine());

            Console.WriteLine("Paid:");
            int paid = int.Parse(Console.ReadLine());

            int change = amountDue - paid;

            Console.WriteLine($"Change due: {change}");

            makeChange(change, denominations.Length - 1);

            Console.ReadLine();
        }

        public static void makeChange(int change, int denom)
        {
            if (denom < 0) return;

            Console.Write((change / denominations[denom]) + " " + denominations[denom] + "s");
            Console.WriteLine();

            makeChange(change % denominations[denom], denom - 1);
        }
    }
}

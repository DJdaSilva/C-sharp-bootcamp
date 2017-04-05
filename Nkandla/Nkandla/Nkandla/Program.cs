using System;

namespace SouthAfrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Nkandla Nkandla = new Nkandla();

            Politician Helen = new Politician("Helen Zille", PersonType.Politician)
            {
                politicalParty = "DA",
                age = 67,
            };

            Politician Julius = new Politician("Julius Malema", PersonType.Politician)
            {
                politicalParty = "EFF",
                age = 43,
            };

            Politician Cyril = new Politician("Cyril Ramphosa", PersonType.Politician)
            {
                politicalParty = "ANC",
                age = 43,
            };

            Console.WriteLine(Nkandla.accept(Cyril));

            Console.ReadLine();
        }
    }
}

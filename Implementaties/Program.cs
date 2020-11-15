using System;

namespace Implementaties
{
    class Program
    {
        static void Main()
        {
            string ibanNummer = "BE68539007547034";
            decimal saldo = 0m;
            do
            {
                Console.WriteLine($"Saldo van {ibanNummer}: {saldo}");
                Console.Write("Actie (stort/haalaf)?: ");
                string actie = Console.ReadLine();
                decimal bedrag = 0m;
                if (actie == "stort" || actie == "haalaf")
                {
                    Console.Write("Bedrag?: ");
                    bedrag = decimal.Parse(Console.ReadLine());
                }
                if (actie == "stort")
                {
                    saldo = saldo + bedrag;
                }
                else if (actie == "haalaf")
                {
                    saldo = saldo - bedrag;
                }
            } while (true);
        }

    }
}

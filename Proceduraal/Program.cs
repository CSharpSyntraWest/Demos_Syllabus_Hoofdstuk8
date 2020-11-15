using System;

namespace Proceduraal
{
    using System;
    class Program
    {
        static void Main()
        {
            SetIbanNummer("BE68539007547034");
            do
            {
                Console.WriteLine($"Saldo van {GetIbanNummer()}: {Saldo()}");
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
                    Stort(bedrag);
                }
                else if (actie == "haalaf")
                {
                    HaalAf(bedrag);
                }
            } while (true);
        }

        static decimal _saldo;
        static void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
            // ... alle complexe logica die te maken heeft met het storten kan hier geïmplementeerd worden
        }
        static void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
            // ... alle complexe logica die te maken heeft met het afhalen kan hier geïmplementeerd worden
        }
        static decimal Saldo()
        {
            return _saldo;
            // ... alle complexe logica die te maken heeft met het opvragen van het saldo kan hier geïmplementeerd worden
        }

        static string _ibanNummer;
        static void SetIbanNummer(string value)
        {
            _ibanNummer = value;
        }
        static string GetIbanNummer()
        {
            return _ibanNummer;
        }
    }

}

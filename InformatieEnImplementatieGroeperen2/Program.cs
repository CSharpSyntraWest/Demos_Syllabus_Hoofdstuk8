using System;

namespace InformatieEnImplementatieGroeperen2
{
    using System;
    class Program
    {
        static void Main()
        {
            Bankrekening.SetIbanNummer("BE68539007547034");
            do
            {
                Console.WriteLine($"Saldo van {Bankrekening.GetIbanNummer()}: {Bankrekening.Saldo()}");
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
                    Bankrekening.Stort(bedrag);
                }
                else if (actie == "haalaf")
                {
                    Bankrekening.HaalAf(bedrag);
                }
            } while (true);
        }
    }
    class Bankrekening
    {
        private static decimal _saldo;
        public static void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
        }
        public static void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
        }
        public static decimal Saldo()
        {
            return _saldo;
        }
        private static string _ibanNummer;
        public static void SetIbanNummer(string value)
        {
            _ibanNummer = value;
        }
        public static string GetIbanNummer()
        {
            return _ibanNummer;
        }
    }


}

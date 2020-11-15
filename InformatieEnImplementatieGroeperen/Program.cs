using System;

namespace InformatieEnImplementatieGroeperen
{
    using System;
  
    class Program
    {
        static void Main()
        {
            Bankrekening.SetIbanNummer("BE68539007547034");
            Bankrekening.Stort(100m);
            Bankrekening.HaalAf(200m);
            Bankrekening.Stort(50m);
            Console.Write($"Saldo van {Bankrekening.GetIbanNummer()}: {Bankrekening.Saldo()}");
            Console.ReadLine();
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

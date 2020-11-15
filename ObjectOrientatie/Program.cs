using System;

namespace ObjectOrientatie
{
    using System;
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag)
        {
            _saldo = _saldo + bedrag;
        }
        public void HaalAf(decimal bedrag)
        {
            _saldo = _saldo - bedrag;
        }
        public decimal Saldo()
        {
            return _saldo;
        }
        private string _ibanNummer;
        public void SetIbanNummer(string value)
        {
            _ibanNummer = value;
        }
        public string GetIbanNummer()
        {
            return _ibanNummer;
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();
            Bankrekening bankrekening2 = new Bankrekening();
            bankrekening1.SetIbanNummer("BE68539007547034");
            bankrekening2.SetIbanNummer("NL05RABO1234123400");
            bankrekening1.Stort(100m);
            bankrekening2.HaalAf(200m);
            Console.WriteLine($"{bankrekening1.GetIbanNummer()}: {bankrekening1.Saldo()}");
            Console.WriteLine($"{bankrekening2.GetIbanNummer()}: {bankrekening2.Saldo()}");
            Console.ReadLine();
        }
    }

}

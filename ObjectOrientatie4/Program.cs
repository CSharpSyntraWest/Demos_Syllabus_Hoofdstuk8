using System;

namespace ObjectOrientatie4
{
    using System;
    class Program
    {
        static void Main()
        {
            Bankrekening bankrekening1 = new Bankrekening();
            bankrekening1.SetIbanNummer("BE68539007547034");
            do
            {
                Console.WriteLine($"Saldo van {bankrekening1.GetIbanNummer()}: {bankrekening1.Saldo()}");
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
                    bankrekening1.Stort(bedrag);
                }
                else if (actie == "haalaf")
                {
                    bankrekening1.HaalAf(bedrag);
                }
            } while (true);
        }
    }
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

}

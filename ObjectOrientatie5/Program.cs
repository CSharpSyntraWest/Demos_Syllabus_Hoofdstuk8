using System;

namespace ObjectOrientatie5
{
    using System;
    class Program
    {
        static void Main()
        {
            Bankrekening[] bank = { new Bankrekening(), new Bankrekening(), new Bankrekening() };
            bank[0].SetIbanNummer("BE68539007547034");
            bank[1].SetIbanNummer("NL05RABO1234123400");
            bank[2].SetIbanNummer("LU280019400644750000");
            do
            {
                PrintSaldi(bank);
                Console.Write("Te bewerken bankrekening?: ");
                int indexTeBewerkenBankrekening = int.Parse(Console.ReadLine()) - 1;
                Bankrekening teBewerkenBankrekening = bank[indexTeBewerkenBankrekening];
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
                    teBewerkenBankrekening.Stort(bedrag);
                }
                else if (actie == "haalaf")
                {
                    teBewerkenBankrekening.HaalAf(bedrag);
                }
            } while (true);
        }
        static void PrintSaldi(Bankrekening[] bank)
        {
            for (int index = 0; index <= bank.Length - 1; index++)
            {
                Console.WriteLine($"{index + 1}: {bank[index].GetIbanNummer()}: {bank[index].Saldo()}");
            }
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

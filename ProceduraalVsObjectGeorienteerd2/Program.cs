using System;

namespace ProceduraalVsObjectGeorienteerd2
{
    using System;
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag) { _saldo = _saldo + bedrag; }
        public decimal Saldo() { return _saldo; }
        public bool IsHogerDan(Bankrekening andereBankrekening)
        {
            return this.Saldo() > andereBankrekening.Saldo();
        }
    }
    class Program
    {
        static void Main()
        {
            Bankrekening b1 = new Bankrekening();
            b1.Stort(500m);
            Bankrekening b2 = new Bankrekening();
            b2.Stort(5000m);

            if (b1.IsHogerDan(b2))
            { Console.WriteLine("Bankrekening 1 is de hoogste."); }
            else
            { Console.WriteLine("Bankrekening 2 is de hoogste."); }

            Console.ReadLine();
        }
    }

}

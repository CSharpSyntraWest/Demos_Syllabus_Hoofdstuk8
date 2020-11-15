using System;

namespace ProceduraalVsObjectGeorienteerd
{
    using System;
    class Bankrekening
    {
        private decimal _saldo;
        public void Stort(decimal bedrag) { _saldo = _saldo + bedrag; }
        public decimal Saldo() { return _saldo; }
        public static Bankrekening Hoogste(Bankrekening bankrekening1, Bankrekening bankrekening2)
        {
            Bankrekening hoogste = bankrekening1;
            if (bankrekening2.Saldo() > bankrekening1.Saldo()) hoogste = bankrekening2;
            return hoogste;
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

            Bankrekening hoogste = Bankrekening.Hoogste(b1, b2);
            if (object.ReferenceEquals(b1, hoogste))
            { Console.WriteLine("Bankrekening 1 is de hoogste."); }
            else
            { Console.WriteLine("Bankrekening 2 is de hoogste."); }

            Console.ReadLine();
        }
    }

}

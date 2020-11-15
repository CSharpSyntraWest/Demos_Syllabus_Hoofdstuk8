using System;

namespace KlasseGerelateerd
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankrekening bankrekening1 = new Bankrekening();
            Bankrekening bankrekening2 = new Bankrekening();
            //bankrekening1.SetIbanNummer("BE68539007547034"); //Dit lukt niet, want SetIbanNummer is static methode
            //bankrekening2.SetIbanNummber("BE6853900754145");//Dit lukt niet, want SetIbanNummer is static methode
        }
    }
}

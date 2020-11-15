using System;
using System.Collections.Generic;
using System.Text;

namespace KlasseGerelateerd
{
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

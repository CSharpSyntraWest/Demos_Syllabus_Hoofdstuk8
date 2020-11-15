using System;

namespace LokaleVariabelenOpHetActivatierecordVoorbeeld2
{
    class LokaleVariabelenOpHetActivatierecordVoorbeeld2
    {
        static void Main()
        {
            Verhoog();
            Verhoog();
            Verhoog();

            Console.ReadLine();
        }
        static int _teller;
        static void Verhoog()
        {
            _teller += 1;
            Console.WriteLine(_teller);
        }

    }
}

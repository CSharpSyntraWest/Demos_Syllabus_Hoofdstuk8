using System;

namespace DoorgevenVanWaardenVoorbeeld2
{
    class DoorgevenVanWaardenVoorbeeld2
    {
        static string[] _personeel = new string[3];
        static int _aantal = 1;
        static void Main()
        {
            _personeel[0] = "Jan";

            do
            {
                PrintPersoneel();
                Console.Write("Actie (aanwerven/laatste ontslaan)?: ");
                string actie = Console.ReadLine();

                if (actie == "aanwerven")
                {
                    Console.Write("Nieuwe naam?: ");
                    string nieuweNaam = Console.ReadLine();
                    VoegToeAanPersoneel(nieuweNaam);
                }
                else if (actie == "laatste ontslaan")
                {
                    VerwijderLaatsteUitPersoneel();
                }
            } while (true);
        }
        static void PrintPersoneel()
        {
            Console.WriteLine("Personeel:");
            for (int index = 0; index < _aantal; index++)
            {
                Console.WriteLine("- " + _personeel[index]);
            }
        }
        static void VoegToeAanPersoneel(string nieuweNaam)
        {
            _aantal += 1;
            if (_aantal > _personeel.Length) Array.Resize(ref _personeel, _personeel.Length * 2);
            _personeel[_aantal - 1] = nieuweNaam;
        }
        static void VerwijderLaatsteUitPersoneel()
        {
            _aantal -= 1;
            _personeel[_aantal] = "";
        }

    }
}

using System;

namespace DoorgevenVanWaardenVoorbeeld
{
    class DoorgevenVanWaardenVoorbeeld
    {

        static void Main()
        {
            string[] personeel = new string[3];
            int aantal = 1;
            personeel[0] = "Jan";

            do
            {
                PrintPersoneel(personeel, aantal);
                Console.Write("Actie (aanwerven/laatste ontslaan)?: ");
                string actie = Console.ReadLine();

                if (actie == "aanwerven")
                {
                    Console.Write("Nieuwe naam?: ");
                    string nieuweNaam = Console.ReadLine();
                    VoegToeAanPersoneel(ref personeel, nieuweNaam, ref aantal);
                }
                else if (actie == "laatste ontslaan")
                {
                    VerwijderLaatsteUitPersoneel(personeel, ref aantal);
                }
            } while (true);
        }
        static void PrintPersoneel(string[] personeel, int aantal)
        {
            Console.WriteLine("Personeel:");
            for (int index = 0; index < aantal; index++)
            {
                Console.WriteLine("- " + personeel[index]);
            }
        }
        static void VoegToeAanPersoneel(ref string[] personeel, string nieuweNaam, ref int aantal)
        {
            aantal += 1;
            if (aantal > personeel.Length) Array.Resize(ref personeel, personeel.Length * 2);
            personeel[aantal - 1] = nieuweNaam;
        }
        static void VerwijderLaatsteUitPersoneel(string[] personeel, ref int aantal)
        {
            aantal -= 1;
            personeel[aantal] = "";
        }

    }
}

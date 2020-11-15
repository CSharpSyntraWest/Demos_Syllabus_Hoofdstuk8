using System;

namespace ObjectOrientatie3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Math.Round(12.34));           // klasse gerelateerde Round

            DateTime datum1 = new DateTime(2020, 11, 16);
            Console.WriteLine("{0:dd/MM/yyyy}",datum1.AddDays(1));           // instantie gerelateerde AddDays

            Console.WriteLine(DateTime.IsLeapYear(2018));   // klasse gerelateerde IsLeapYear

            Console.ReadLine();
        }

    }
}

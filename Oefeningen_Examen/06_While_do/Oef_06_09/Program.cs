using System;

namespace Oef_06_09
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "Voorbeeld 3";

            string naamKat, datum, binnenBuiten;
            DateTime geboorteDatum;
            DateTime wrongDate = new DateTime();
            bool test;

            Console.Write("Geef de naam van de kat: ");
            naamKat = Console.ReadLine();


            //Console.Write("Geef de geboortedatum: ");
            //datum = Console.ReadLine();
            //DateTime.TryParse(datum, out geboorteDatum);
            do
            {
                Console.Write("Geef de geboortedatum: ");
                datum = Console.ReadLine();
                test = DateTime.TryParse(datum, out geboorteDatum);
            } while (geboorteDatum == wrongDate);

            Console.Write("Is het een binnen- of buitenkat?");
            binnenBuiten = Console.ReadLine();

            Console.WriteLine(naamKat + geboorteDatum.ToShortDateString() + binnenBuiten);
        
        }

    }
}

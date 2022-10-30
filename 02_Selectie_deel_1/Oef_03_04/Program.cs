using System;

namespace Oef_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam, voornaam;
            int keuze;
            string[] tijdschrift = {"", "Anna", "Knippie", "Vtwonen", "Voetbal international", "Wandelen & fietsen", "Zoom NL", "Runners" };

            Console.Write("Geef je voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("Geef je achternaam: ");
            naam = Console.ReadLine().ToUpper();
            Console.Write("Geef een getal: ");
            keuze = int.Parse(Console.ReadLine());





             (keuze > 0 && keuze < 8) { 
                Console.WriteLine($"{voornaam} {naam}, tijdschrift: \"{tijdschrift[keuze]}\"");
            return;}
            Console.WriteLine($"{voornaam} {naam}, tijdschrift: -");


        }
    }
}

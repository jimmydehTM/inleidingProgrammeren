using System;

namespace Oef_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int leeftijd;
            string voornaam, familienaam;

            Console.Write("Geef een voornaam: ");
            voornaam = Console.ReadLine();

            Console.Write("Geef een familienaam: ");
            familienaam = Console.ReadLine();

            Console.Write("Geef een leeftijd: ");
            leeftijd = int.Parse(Console.ReadLine());


            if (leeftijd > 17)
            {
                Console.Write($"{voornaam} {familienaam}: Volwassenen");
                return;
            }
            Console.Write($"{voornaam} {familienaam}: Jeugd");


        
    }
    }
}

using System;
using System.Collections.Generic;

namespace Oef_07_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string naam, jaNee;
            List<string> namen = new List<string>();
            


            do {
                Console.Write("Wil je een naam toevoegen? ");
                jaNee = Console.ReadLine().ToLower();

            } while (jaNee != "ja" && jaNee != "nee");

            while (jaNee == "ja") {

                do
                {
                    Console.Write("Geef een naam: ");
                    naam = Console.ReadLine();

                } while (string.IsNullOrWhiteSpace(naam));

                namen.Add(naam);

                do
                {
                    Console.Write("Wil je nog een naam toevoegen? ");
                    jaNee = Console.ReadLine().ToLower();

                } while (jaNee != "ja" && jaNee != "nee");

            }

            if (namen.Count == 0)
            {
                Console.WriteLine(namen.Count);
                Console.WriteLine("Er zijn geen aanwezigen!");
            }
            else
            {
                Console.WriteLine("namen: ");
                foreach (string persoon in namen) 
                {
                    Console.WriteLine(persoon);
                }
            }

            
            
        }
    }
}

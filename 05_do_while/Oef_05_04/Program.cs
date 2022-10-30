using System;
using System.Xml;

namespace Oef_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zin, input;
            int pogingen;

            input = "";
            zin = "Op de stoel ligt een zonnehoed en peperkoek";
            pogingen = 1;

            Console.WriteLine("Probeer volgende zin te herhalen:");
            Console.WriteLine("======");
            Console.WriteLine($"{zin}");
            Console.WriteLine("Druk op enter!");
            Console.ReadLine();
            Console.Clear();

            do
            {
                input = Console.ReadLine();
                if (input != zin) { 
                    Console.WriteLine("Fout! Probeer opnieuw:");
                    pogingen ++;
                }
                   
            } while (input != zin);

            
            if (input == zin && pogingen > 1)
            {
                Console.WriteLine($"Je had {pogingen} pogingen nodig!");
            }
            else {Console.WriteLine($"Je had {pogingen} poging nodig!"); }
        }
    }
}

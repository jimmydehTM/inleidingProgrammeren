using System;
using System.Globalization;

namespace Oef_06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string familienaam = "", voornaam = "", keuze = ""; ;
            int gekozen = 0;
            string[] magazines = new string[] {"", "Anna", "Knippie", "VtWonen", "Voetbal International", "Wandelen & fietsen", "Zoom NL", "Runners"};

            

            while (gekozen != 8) {
                while (String.IsNullOrEmpty(familienaam))
                {
                    //Console.Write("Geef de familienaam: ");
                    familienaam = Console.ReadLine();
                }

                while (String.IsNullOrEmpty(voornaam))
                {
                    //Console.Write("Geef de voornaam: ");
                    voornaam = Console.ReadLine();
                }
                while (String.IsNullOrEmpty(keuze))
                {
                    //Console.WriteLine("Geef de keuze: ");
                    
                    keuze = Console.ReadLine();

                }
                int.TryParse(keuze, out gekozen);
                if (gekozen < 8 && gekozen > 0)
                {
                    Console.WriteLine($"Wij raden \"{magazines[gekozen]}\" aan.");
                    keuze = Console.ReadLine();
                }
                else if (gekozen < 0)
                {
                    //Console.WriteLine("Geef de keuze: ");
                    keuze = Console.ReadLine();
                } else if (gekozen > 8 ) {
                    //Console.WriteLine("Geef de keuze: ");
                    keuze = Console.ReadLine();
                }


            }
            Console.Write("Wij raden niets aan.");
        }
    }
}

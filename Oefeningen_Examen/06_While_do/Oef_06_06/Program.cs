using System;
using System.Net.WebSockets;

namespace Oef_06_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int ticket = 0,
                totaal = 0;

           

            while (!String.IsNullOrWhiteSpace(input)) {

                Console.Write("Hoeveel tickets wil je? ");
                input = Console.ReadLine();
                int.TryParse(input, out ticket);
                if (ticket > 0) { totaal += ticket; }

            }

            Console.WriteLine($"Totaal aantal tickets: {totaal}");
            Console.WriteLine($"Totale prijs: {totaal * 15}");
        }
    }
}

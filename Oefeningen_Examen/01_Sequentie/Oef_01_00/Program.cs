using System;
using System.Net.WebSockets;

namespace Oef_01_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2;

            Console.Write("Geef de lengte van de korte zijde: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef de lengte van de lange zijde: ");
            getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Omtrek: {(getal1*2) + (getal2*2)}");
            Console.WriteLine($"Oppervlakte: {getal1*getal2}");
        }
    }
}

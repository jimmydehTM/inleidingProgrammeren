using System;

namespace Oef_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, getal4;

            Console.WriteLine("Geef 4 getallen: ");
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Optelling: {getal1 + getal3}");
            Console.WriteLine($"Vermenigvuldiging: {getal2*getal4}");
        }
    }
}

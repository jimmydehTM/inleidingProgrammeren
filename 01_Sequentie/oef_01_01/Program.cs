using System;

namespace oef_01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3, getal4;

            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            int som = getal1 + getal3;

            int product = getal2 * getal4;

            Console.WriteLine($"Optelling: {som}");
            Console.WriteLine($"Vermenigvuldiging: {product}");
        }
    }
}

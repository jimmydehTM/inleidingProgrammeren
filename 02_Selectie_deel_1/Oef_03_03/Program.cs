using System;

namespace Oef_03_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3;

            char code;

            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            code = char.Parse(Console.ReadLine());

            if (code == 'a' || code == 'A')
            {
                Console.WriteLine($"Uitkomst: {getal1 + getal2 + getal3}");
            }
            else if (code == 'b' || code == 'B')
            {
                Console.WriteLine($"Uitkomst: {getal1 * getal3}");
            }
            else if (code == 'c' || code == 'C')
            {
                Console.WriteLine($"Uitkomst: {getal3 - getal2}");
            }
            else if (code == 'd' || code == 'D')
            {
                if (getal1 > 0)
                {
                    Console.WriteLine($"Uitkomst: {Math.Sqrt(getal1)}");
                }
                else { Console.WriteLine("Foutieve invoer."); }
            }
            else if (getal1 > getal2 && getal1 > getal3) { Console.WriteLine($"Uitkomst: {getal1}"); }
            else if (getal2 > getal1 && getal2 > getal3) { Console.WriteLine($"Uitkomst: {getal2}"); }
            else {Console.WriteLine($"Uitkomst: {getal3}"); }


        }
    }
}

using System;

namespace Oef_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, uitkomst;

            Console.Write("Geef een getal: ");
            getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef nog een getal: ");
            getal2 = int.Parse(Console.ReadLine());


            if (getal1 == 0)
            {
                Console.Write($"{getal2} is niet deelbaar door 0");
            }
            else if (getal2 == 0)
            {
                Console.Write($"{getal1} is niet deelbaar door 0");
            }
            else { Console.Write($"{getal1} / {getal2} = {getal1/getal2}"); }
        
        }
    }
}

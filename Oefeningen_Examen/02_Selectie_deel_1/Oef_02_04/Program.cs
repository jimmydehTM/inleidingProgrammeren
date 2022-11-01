using System;

namespace Oef_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal;
            

            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());

            


            if (getal % 5 == 0 && getal % 11 == 0)
            {
                Console.Write($"Deelbaar.");
                return;
            }
            Console.Write($"Niet deelbaar.");
        }
    }
}

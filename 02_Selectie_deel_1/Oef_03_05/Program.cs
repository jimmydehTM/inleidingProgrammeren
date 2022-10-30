using System;
using System.Collections.Generic;

namespace Oef_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cord1, cord2;

            Console.Write("Geef de eerste coördinaat: ");
            cord1 = int.Parse(Console.ReadLine());

            Console.Write("Geef de tweede coördinaat: ");
            cord2 = int.Parse(Console.ReadLine());


            if (cord1 < 0 && cord2 >= 0) { Console.WriteLine("Punt ligt in het tweede kwadrant.");
                return;
            } else if (cord2 < 0 && cord1 >= 0) { Console.WriteLine("Punt ligt in het vierde kwadrant.");
                return;
            }
            else if (cord1 < 0 && cord2 < 0) {
                Console.WriteLine("Punt ligt in het derde kwadrant.");
                return; }
            else if (cord1 == 0 && cord2 == 0) {
                Console.WriteLine("Punt ligt in de oorsprong.");
                return;
            } Console.WriteLine("Punt ligt in het eerste kwadrant.");





        }
    }
}

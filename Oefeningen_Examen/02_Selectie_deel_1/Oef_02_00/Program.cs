using System;

namespace Oef_02_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal;

            Console.Write("Geef een getal: ");
            getal = int.Parse(Console.ReadLine());

            if (getal < 0) { 
                Console.Write("Negatief");
            } else { 
                Console.Write("Positief"); 
            }

        }
    }
}

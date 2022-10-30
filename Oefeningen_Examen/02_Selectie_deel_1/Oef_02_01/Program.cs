using System;

namespace Oef_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int getal1, getal2, nieuwGetal;
            
            Console.Write("Geef een getal: ");
            getal1 = int.Parse(Console.ReadLine());


            Console.Write("Geef nog een getal: ");
            getal2 = int.Parse(Console.ReadLine());

            if (getal1 < getal2)
            {
                nieuwGetal = getal2 - getal1;
                Console.Write($"{getal2} - {getal1} = {nieuwGetal}");
            }
            else 
            {
                nieuwGetal = getal1 - getal2;
                Console.Write($"{getal1} - {getal2} = {nieuwGetal}");
            }

            
        }
    }
}

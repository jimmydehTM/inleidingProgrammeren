using System;

namespace Oef_02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie van variabelen
            int getal1 = int.Parse(Console.ReadLine());
            int getal2 = int.Parse(Console.ReadLine());


            if (getal1 > getal2)
            {
                Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
                return;
            }

            Console.WriteLine($"{getal2} - {getal1} = {getal2 - getal1}");
        }
    }
}

using System;

namespace Oef_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie van variabelen
            int getal1 = int.Parse(Console.ReadLine());
            int getal2 = int.Parse(Console.ReadLine());


            if (getal1 == 0)
            {
                Console.WriteLine($"{getal2} is niet deelbaar door 0.");
            }
            else if (getal2 == 0)
            {
                Console.WriteLine($"{getal1} is niet deelbaar door 0.");
            }
            else
            {
                Console.WriteLine($"{getal1} / {getal2} = {getal1 / getal2}");
            }
        }
    }
}

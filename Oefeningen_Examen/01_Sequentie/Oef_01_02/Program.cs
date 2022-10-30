using System;

namespace Oef_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percentage;
            float prijsExcl, prijsIncl;

            Console.Write("Geef de prijs zonder BTW: ");
            prijsExcl = float.Parse(Console.ReadLine());

            Console.Write("Geef het BTW bedrag: ");
            percentage = int.Parse(Console.ReadLine());


            
            prijsIncl = prijsExcl + ((prijsExcl / 100) * percentage);

            Console.WriteLine($"Prijs inclusief BTW: {prijsIncl:N2}");
        }
    }
}

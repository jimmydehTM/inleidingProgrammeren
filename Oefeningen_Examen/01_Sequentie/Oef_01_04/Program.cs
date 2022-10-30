using System;

namespace Oef_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nationaleOproep, internationaleOproep, totaalOproepen, percentage = 0.21;
            

            Console.Write("Geef het aantal nationale oproepen: ");
            nationaleOproep = int.Parse(Console.ReadLine());

            Console.Write("Geef het aantal internationale oproepen: ");
            internationaleOproep = int.Parse(Console.ReadLine());

            totaalOproepen = (nationaleOproep + internationaleOproep) * 0.12 + 23;

            Console.Write($"Totaal te betalen: {(totaalOproepen * percentage) + totaalOproepen:N2}");
        }
    }
}

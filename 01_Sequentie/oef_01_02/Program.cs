using System;

namespace oef_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double prijs;
            double btw;
            double btwGetal;

            prijs = double.Parse(Console.ReadLine());
            btw = double.Parse(Console.ReadLine());
            btwGetal = (btw/100) * prijs;

            double inclBtw = btwGetal + prijs;

            Console.WriteLine($"Prijs inclusief BTW: {inclBtw}");
            
        }
    }
}

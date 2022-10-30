using System;

namespace Oef_01_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double natOproepen, intOproepen;
            double btw = 0.21;
            double oproep = 0.12;
            double vastePrijs = 23;

            natOproepen = double.Parse(Console.ReadLine());
            intOproepen = double.Parse(Console.ReadLine());

            double ZonderBtw = vastePrijs + (natOproepen + intOproepen) * oproep;
            double btwGetal = ZonderBtw * btw;
            double totaalPrijs = ZonderBtw + btwGetal;

            Console.WriteLine($"Totaal te betalen: {totaalPrijs} euro");


        }
    }
}

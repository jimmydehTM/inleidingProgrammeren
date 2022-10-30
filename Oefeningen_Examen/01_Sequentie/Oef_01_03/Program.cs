using System;

namespace Oef_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int aantalVolwassenen, aantalKinderen;
            double totaal;

            Console.Write("Geef het totaal aantal volwassenen: ");
            aantalVolwassenen =  int.Parse(Console.ReadLine());

            Console.Write("Geef het aantal kinderen: ");
            aantalKinderen = int.Parse(Console.ReadLine());

            totaal = (aantalVolwassenen * 10) + (aantalKinderen * 7.5);

            Console.Write($"Totaal te betalen: {totaal} euro");
        }
    }
}

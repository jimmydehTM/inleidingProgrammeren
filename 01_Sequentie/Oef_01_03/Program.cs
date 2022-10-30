using System;

namespace Oef_01_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double volwassenen, kinderen;

            volwassenen = double.Parse(Console.ReadLine());
            kinderen = double.Parse(Console.ReadLine());

            double prijsVolwassene = volwassenen * 10;
            double prijsKinderen = kinderen * 7.50;

            Console.WriteLine($"Totaal te betalen: {prijsVolwassene + prijsKinderen} euro");
        }
    }
}
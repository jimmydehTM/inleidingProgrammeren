using System;

namespace Oef_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double fahrenheit, celcius;

            Console.Write("Hoeveel graden celcius? ");
            celcius = double.Parse(Console.ReadLine());

            fahrenheit = celcius * 9 / 5 + 32;

            Console.Write($"Fahrenheit: {fahrenheit:N2}");
        }
    }
}

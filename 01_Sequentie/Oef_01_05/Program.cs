using System;

namespace Oef_01_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double toFarenheit = celcius * 9 / 5 + 32;

            Console.WriteLine($"Fahrenheit: {toFarenheit}");
        }
    }
}

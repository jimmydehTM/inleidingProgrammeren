using System;

namespace Oef_05_00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string invoer;
            double hoeveelheid;
            int tijd = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.Title = "05 dowhile - oplossing 00";
            do
            {
                Console.Write("Hoeveelheid koffie (mg): ");
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out hoeveelheid));
            do
            {
                tijd += 5;
                hoeveelheid = hoeveelheid / 2;
            } while (hoeveelheid > 1);
            Console.WriteLine($"Totale tijd: {tijd} uur");
            Console.ReadLine();
        }
    }
}

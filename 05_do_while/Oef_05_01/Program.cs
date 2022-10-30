using System;

namespace Oef_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer;
            int getal1, getal2, resultaat;
            
            

            do
            {
                //Console.Write("Geef een getal: ");
                invoer = Console.ReadLine();
                
            } while (!int.TryParse(invoer, out getal1));
            do
            {
                //Console.Write("Geef nog een getal: ");
                invoer = Console.ReadLine();  

            } while (!int.TryParse(invoer, out getal2));

            if (getal1 > getal2)
            {
                resultaat = getal1 - getal2;
                Console.WriteLine($"{getal1} - {getal2} = {resultaat}");
            }
            else {
                resultaat = getal2 - getal1;
                Console.WriteLine($"{getal2} - {getal1} = {resultaat}"); }
            
        }
    }
}

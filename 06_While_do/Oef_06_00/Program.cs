using System;

namespace Oef_06_00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input;
            int totaal = 0;

            input = int.Parse(Console.ReadLine());
            
            while (input > 0)
            {
                totaal = totaal + input;
                input = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Totaal: {totaal}");
        }
    }
}

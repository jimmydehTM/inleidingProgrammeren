using System;

namespace Oef_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int prijs, totaal, lid, aantal;
            aantal = 0;
            totaal = 0;
            lid = 0;

            do
            {
                
                input = Console.ReadLine();
                int.TryParse(input, out prijs);
                aantal ++;
                totaal += prijs;
            } while (aantal < 5);

            

            input = Console.ReadLine();

            int.TryParse(input, out lid);

            if (int.TryParse(input, out lid) && lid < 6) {
                switch (lid) { 
                    case 1: Console.WriteLine($"Totaalprijs: {totaal -= 5} euro");
                        break;
                    case 2:
                        Console.WriteLine($"Totaalprijs: {totaal -= 10 } euro");
                        break ;
                    case 3:
                        Console.WriteLine($"Totaalprijs: {totaal -= 20} euro");
                        break;
                    case 4:
                        Console.WriteLine($"Totaalprijs: {totaal -= 30} euro");
                        break;
                        default:
                        Console.WriteLine($"Totaalprijs: {totaal -= 50} euro");
                        break;
                }
            }
        }
    }
}

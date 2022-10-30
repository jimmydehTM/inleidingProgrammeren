using System;

namespace Oef_05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string invoer;
            int tafel, antwoord, score = 1;

            invoer = "";

              
                do
                {
                    Console.Write("Geef een tafel: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out tafel));
            while (tafel != 0)
            {
                for (int i = 0; i < 10; i++)
                {

                    do
                    {
                        Console.WriteLine($"{tafel} x {i + 1} = ");
                        invoer = Console.ReadLine();
                    } while (!int.TryParse(invoer, out antwoord));

                    if (tafel * (i + 1) == antwoord)
                    {
                        score++;
                    }
                }
                Console.WriteLine($"U heeft {score}/10 behaald!");
            }
        }
    }
}

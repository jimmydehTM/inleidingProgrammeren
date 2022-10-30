using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaratie van variabelen
            int getal = int.Parse(Console.ReadLine());

            if (getal < 0)
            {
                Console.WriteLine("Negatief");
                return;
            }

            Console.WriteLine("Positief");
        }
    }
}

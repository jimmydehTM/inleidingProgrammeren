using System;

namespace Oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            int getal3;
            int getal4;
            int som, product;


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            
            getal1 = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());
            getal4 = int.Parse(Console.ReadLine());

            som = getal1 + getal2;
            product = getal3 + getal4;
            
            //Commentaarlijn
            Console.WriteLine($"Som: {som}");
            Console.WriteLine($"Product: {product}");
            //Console.ReadLine();
            
             


        }
    }
}

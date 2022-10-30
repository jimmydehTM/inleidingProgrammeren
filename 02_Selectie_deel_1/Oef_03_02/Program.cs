using System;

namespace Oef_03_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jaartal;

            jaartal = int.Parse(Console.ReadLine());

            if (jaartal > 1582)
            {
                if (jaartal % 4000 == 0)
                {
                    Console.WriteLine($"{jaartal} is geen schrikkeljaar.");
                }
                else if (jaartal % 400 == 0) { Console.WriteLine($"{jaartal} is een schrikkeljaar."); }
                else if (jaartal % 100 == 0) { Console.WriteLine($"{jaartal} is geen schrikkeljaar."); }
                else if (jaartal % 4 == 0) { Console.WriteLine($"{jaartal} is een schrikkeljaar."); }
                else { Console.WriteLine($"{jaartal} is geen schrikkeljaar."); }
            } 
            else if (jaartal < 1582)
            {
                if (jaartal % 4 == 0)
                {
                    Console.WriteLine($"{jaartal} is een schrikkeljaar.");
                }
                else if (jaartal % 4 != 0)
                {
                    Console.WriteLine($"{jaartal} is geen schrikkeljaar.");
                }
                else { Console.WriteLine($"{jaartal} is geen schrikkeljaar."); }

            }
        }
    }
}

using System;

namespace Oef_02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pijl;


            Console.Write("Schiet een pijl!: ");
            pijl = int.Parse(Console.ReadLine());




            switch (pijl) {

                case 1: Console.WriteLine("0 punten.");
                break;
                case 2: Console.WriteLine("20 punten.");
                break ;
                case 3: Console.WriteLine("50 punten.");
                break;
                case 4: Console.WriteLine("100 punten.");
                break;
                default: Console.WriteLine("MISS!");
                break;
            }
        }
    }
}

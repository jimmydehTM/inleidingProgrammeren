using System;

namespace validatie_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double getal;
            


            

                Console.Write("Geef een getal: ");
                getal = double.Parse(Console.ReadLine());
            if (getal is double)
            {
                Console.WriteLine("komma getal");
            } else Console.WriteLine("Geen komma getal");









        }
    }
}

using System;
using System.Collections.Generic;

namespace Oef_07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> getallen = new List<int>();
            string input = "";
            bool test;
            int number;
            int aantalPositief = 0;
            int negatief = 0;

            do
            {
                Console.WriteLine("Geef een cijfer");
                input = Console.ReadLine();
                test = int.TryParse(input, out number);
                getallen.Add(number);

            } while (!String.IsNullOrWhiteSpace(input));


            for (int i = 0; i < getallen.Count; i++) {

                if (getallen[i] < 0)
                {

                    negatief += getallen[i];
                }
                else if (getallen[i] > 0) {

                    aantalPositief++;
                }

                
            }
            Console.WriteLine($"Aantal positief: {aantalPositief}");
            Console.WriteLine($"Negatieve som: {negatief}");
        }
    }
}

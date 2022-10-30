using System;

namespace oef_01_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int korteZijde, langeZijde;

            
            korteZijde = int.Parse(Console.ReadLine());
            langeZijde = int.Parse(Console.ReadLine());


            int oppervlakte = korteZijde * langeZijde;
            int omtrek = (2 * korteZijde) + (2 * langeZijde);


            Console.WriteLine($"omtrek: {omtrek}");
            Console.WriteLine($"oppervlakte: {oppervlakte}");
            




        }
    }
}

using System;

namespace Oef_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int raamPlaatsen, gewonePlaatsen, passagiers;
            string geefPlaats;

            raamPlaatsen = 0;
            gewonePlaatsen = 0;
            passagiers = 0;
            geefPlaats = "";
            

            do
            {
                Console.WriteLine("Kies je plaats! N is een gewone plaats, Y een plaats aan het raam.");
                geefPlaats = Console.ReadLine().ToUpper();
                passagiers ++;
                if (geefPlaats == "Y")
                {
                    raamPlaatsen ++;
                    
                }
                else { 
                    gewonePlaatsen ++;
                    
                }

            } while (raamPlaatsen < 4 && passagiers < 8);

            Console.WriteLine($"Er zijn {passagiers} passagiers. {raamPlaatsen} zitten er aan het raam.");
        }
    }
}

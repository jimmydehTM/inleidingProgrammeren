using System;

namespace Oef_06_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string naam = "notNull:)", score = "", lijst = "";
            int totaal = 0, aantal = 0, result = 0;
            bool isEenGetal = true;
            
             
            

            while (!String.IsNullOrEmpty(naam)) {


                //Console.Write("Geef je naam: ");
                naam = Console.ReadLine();
                if (naam == "") { break; }
                
                do
                {
                    //Console.Write("Geef de score: ");
                    score = Console.ReadLine();
                    isEenGetal = int.TryParse(score, out result);

                } while (!isEenGetal);


                lijst += $"{naam} ({score})\n";
                totaal += result;

                aantal++;

            }
            if (lijst == "") { Console.WriteLine("Geen aanwezigen"); }
            else
            {
                Console.Write(lijst);
                Console.WriteLine($"Gemiddelde: {totaal / aantal}");
            }
        }
    }
}

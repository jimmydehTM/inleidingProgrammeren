using System;

namespace Oef_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string club = "", teken1, teken2, lengte, breedte;
            int juisteLengte = 0, juisteBreedte = 0;
            string totaalSjaal = "";




            while (true) {

                do
                {
                    Console.Write("Geef een club: ");
                    club = Console.ReadLine();

                } while (String.IsNullOrEmpty(club) || club.Length < 5);

                if (club == "*****") { break; }

                totaalSjaal += club + "\n";

                do {
                    Console.Write("geef een teken1: ");
                    teken1 = Console.ReadLine();
                } while (String.IsNullOrEmpty(teken1));

                do
                {
                    Console.Write("geef een teken2: ");
                    teken2 = Console.ReadLine();
                } while (String.IsNullOrEmpty(teken2));

                

                

                do {
                    Console.Write("geef een lengte: ");
                    lengte = (Console.ReadLine());
                } while (!int.TryParse(lengte, out juisteLengte) || juisteLengte < 4);

                do
                {
                    Console.Write("geef een breedte: ");
                    breedte = (Console.ReadLine());
                } while (!int.TryParse(breedte, out juisteBreedte) || (juisteBreedte <= (juisteLengte / 2)));

                if (juisteLengte % 2 == 0)
                {
                    for (int y = 0; y < juisteLengte / 2; y++)
                    {
                        for (int i = 0; i < juisteBreedte; i++) { totaalSjaal += teken1; }
                        totaalSjaal += "\n";
                        for (int i = 0; i < juisteBreedte; i++) { totaalSjaal += teken2; }
                        totaalSjaal += "\n";

                    }
                }
                
                else {
                    for (int y = 0; y < juisteLengte / 2; y++)
                    {
                        for (int i = 0; i < juisteBreedte; i++) { totaalSjaal += teken1;}
                        totaalSjaal += "\n";
                        for (int i = 0; i < juisteBreedte; i++) { totaalSjaal += teken2;}
                        totaalSjaal += "\n";
                        
                    }
                    for (int i = 0; i < juisteBreedte; i++) { totaalSjaal += teken1; }
                    
                }
            }
            Console.WriteLine(totaalSjaal);
        }
        


       
        }
}


using System;

namespace Oef_06_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string evenement = "", naam = "", check = "", aanwezigen = "";

            while (String.IsNullOrEmpty(evenement))
            {
                Console.Write("Geef de naam van het evenement: ");
                evenement = Console.ReadLine();
                }
                
                Console.WriteLine("Wil je iemand toevoegen?");
                check = Console.ReadLine();


            if (check == "nee")
            {

                Console.WriteLine($"Er zijn geen aanwezigen voor {evenement}!");
                

            }else
            {
                while (check == "ja")
                {
                    Console.Write("Geef een naam: ");
                    naam = Console.ReadLine();
                    aanwezigen += naam + "\n";
                    Console.WriteLine("Wil je nog iemand toevoegen?");
                    check = Console.ReadLine();
                }
                Console.WriteLine($"De aanwezigen voor {evenement}:");
                Console.WriteLine($"{aanwezigen}");
                }
            }

        }
    }


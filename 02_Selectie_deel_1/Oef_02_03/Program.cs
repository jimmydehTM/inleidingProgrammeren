using System;

namespace Oef_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print vraagstelling naar console.
            Console.WriteLine("Geef je voornaam:");
            
            //Declaratie van variabele om input op te slaan.
            string voorNaam = (Console.ReadLine());

            //Print vraagstelling naar console.
            Console.WriteLine("Geef je achternaam:");
            
            //Declaratie van variabele om input op te slaan.
            string naam = (Console.ReadLine());

            //Print vraagstelling naar console.
            Console.WriteLine("Geef je leeftijd:");
            
            //Declaratie van variabele om input op te slaan.
            int leeftijd = int.Parse(Console.ReadLine());

            //if statement dat kijkt of variabele leeftijd lager is dan 18.
            if (leeftijd < 18)
            {   //als if statment 'true' is, print jeugd naar console.
                Console.WriteLine($"{voorNaam} {naam}: Jeugd");
                //Return statement om de code te breken.
                return;
            }
            //print 'volwassenen' naar de console als if statement 'false' is.
            Console.WriteLine($"{voorNaam} {naam}: Volwassenen");
        }
    }
}

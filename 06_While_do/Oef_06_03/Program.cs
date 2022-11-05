using System;

namespace Oef_06_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string team = "", 
                hoeLang = "", 
                hoebreed = "", 
                fig1 = "", 
                figuur1, 
                fig2 = "", 
                figuur2, 
                sjaal= "";

            int lengte, 
                breedte;





            while (true)
            {
                figuur1 = "";
                figuur2 = "";

                    do
                    {
                        Console.Write("Geef een team of ***** om te eindigen: ");
                        team = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(team) || team.Length < 5); //validatie ingave team


                    if (team == "*****") //check om programma te beeindigen
                {
                        Console.WriteLine("Programma is beeindigd...");
                        break;
                    }


                    sjaal += team; //voeg het team toe aan de sjaal
                    sjaal += "\n"; //voeg een nieuwe lijn toe aan de sjaal

                    do
                    {
                        Console.Write("Geef een figuur: ");
                        fig1 = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(fig1)); //validatie voor figuur 1



                    do
                    {
                        Console.Write("Geef nog een figuur: ");
                        fig2 = Console.ReadLine();

                    } while (String.IsNullOrWhiteSpace(fig2)); //validatie voor figuur 2


                    do
                    {

                    Console.Write("Geef een lengte: ");
                    hoeLang = Console.ReadLine();

                    } while (int.TryParse(hoeLang, out lengte) == false || lengte < 4); //check voor ingave lengte

                    do
                    {

                        Console.Write("Geef een breedte: ");
                        hoebreed = Console.ReadLine();


                    } while (int.TryParse(hoebreed, out breedte) == false || breedte < (lengte/2)); //validatie voor ingave breedte

                    for (int i = 0; i < breedte; i++) //maak de figuren de correcte breedte
                    {

                    figuur1 += fig1;
                    figuur2 += fig2;

                    }

                    

                    if (lengte % 2 == 0) //als de lengte een even getal is, druk de sjaal af als volgt:
                    {

                    for (int i = 0; i < lengte / 2; i++)
                    {

                        sjaal += figuur1;
                        sjaal += "\n";
                        sjaal += figuur2;
                        sjaal += "\n";

                    }
                        }//einde if

                    else //is de lengte een oneven getal, druk de sjaal dan af als volgt:
                    {

                    for (int i = 0; i < lengte / 2; i++)
                    {

                        sjaal += figuur1;
                        sjaal += "\n";
                        sjaal += figuur2;
                        sjaal += "\n";

                    }

                    sjaal += figuur1;
                    sjaal += "\n";

                    }//einde else



            }//einde while loop

            Console.WriteLine(sjaal); //drukt de sjaal af



        }
    }
}

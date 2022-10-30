using System;

namespace Oef_06_04
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string invoer, antwoord;
            int tafel;
            int i;

            antwoord = "";


            do
            {

                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out tafel));

            while (tafel != 0)
            {

                do
                {

                    invoer = Console.ReadLine();


                    for (i = 1; i < 11; i++)
                    {



                        antwoord += $"{i} x {tafel} = " + tafel * i + "\n";
                        if (i == 10) { antwoord += "\n"; }

                    }


                } while (!int.TryParse(invoer, out tafel));
            }
            Console.WriteLine(antwoord);
        }
    }
}

    


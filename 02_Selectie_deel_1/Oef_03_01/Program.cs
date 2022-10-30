using System;

namespace Oef_03_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1, getal2, getal3;

            getal1  = int.Parse(Console.ReadLine());
            getal2 = int.Parse(Console.ReadLine());
            getal3 = int.Parse(Console.ReadLine());

            char a = char.Parse(Console.ReadLine());
            

            int cijferCode = int.Parse(Console.ReadLine());


            if (a == 'A' && cijferCode == 1) {
                Console.WriteLine($"{getal1} + {getal2} = " + (getal1 + getal2));
            } 
            else if (a == 'A' && cijferCode == 2) { 
                Console.WriteLine($"{getal2} + {getal3} = " + (getal2 + getal3)); 
            } 
            else if (a == 'A' && cijferCode == 3) { 
                Console.WriteLine($"{getal1} + {getal3} = " + (getal1 + getal3)); 
            }
            else if (a == 'B' && cijferCode == 1) { 
                Console.WriteLine($"{getal1} - {getal2} = " + (getal1 - getal2)); 
            }
            else if (a == 'B' && cijferCode == 2) { 
                Console.WriteLine($"{getal2} - {getal3} = " + (getal2 - getal3)); 
            }
            else if (a == 'B' && cijferCode == 3) { 
                Console.WriteLine($"{getal1} - {getal3} = " + (getal1 - getal3)); 
            }
        }
    }
}

using System;

namespace Oef_05_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plaats;
            int score, pijlen, pijl;
            bool test;
            
            score = 0;
            pijlen = 0;
            pijl = 0;

            do
                {//aantal pijlen

            do
                {//check voor correctheid van input

                Console.WriteLine("Schiet!");
                plaats = Console.ReadLine();
                test = int.TryParse(plaats, out pijl);

                
                if (pijl > 0 && pijl < 5)
                {//als score hoger dan nul en lager dan 5  

                    pijlen++; //verhoog 'pijlen' met 1

                        switch (pijl) //bereken score van treffer.

                        {
                        case 4:
                            score += 100;
                            break;
                        case 3:
                            score += 50;
                            break;
                        case 2:
                            score += 20;
                            break;
                        default:
                            score += 0;
                            break;
                    }//einde van switch
                    
                }//einde van if
                

            } while (!test);//einde van check voor correctheid van input
            } while (pijlen < 3); //einde van check aantal pijlen

            Console.WriteLine($"U hebt {score} punten behaald");
            
        }
    }
}

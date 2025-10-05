using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Main;

namespace oppgaven.Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Velg en av oppgavene mine");
                Console.WriteLine("1: Forskjellige variabler av typene");
                Console.WriteLine("2: En enkel kalkulator");
                Console.WriteLine("0: while - return");


                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    CookieBase cookes = new CookieBase();
                    cookes.ShowData();
                }
                else if (choice == "2")
                {
                    Calculator calculator = new Calculator();
                    calculator.Run();
                }
                else if (choice == "0")
                {
                    Console.WriteLine("---------");
                    return;
                }
                else
                {
                    Console.WriteLine("Ukjent valg. Prøv igjen neste gang.");
                }
            }
        }
    }
}

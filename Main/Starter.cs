using System;
using System.Collections.Generic;
using System.Data.Common;
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
                Console.WriteLine("3: List <string>");
                Console.WriteLine("4: List <int>");
                Console.WriteLine("5: List <double>");
                Console.WriteLine("6: Dictionary");
                Console.WriteLine("0: slutt programmet");
                Console.Write("\nDitt valg: ");

                string? choice = Console.ReadLine();

                if (choice == "1")
                {
                    CookieBase cookes = new CookieBase();
                    cookes.ShowData();
                    cookes.ShowData1();
                }
                else if (choice == "2")
                {
                    Calculator calculator = new Calculator();
                    calculator.Run();
                }
                else if (choice == "3")
                {
                    Collections ListString = new Collections();
                    ListString.ListSrting();
                }
                else if (choice == "4")
                {
                    Collections CashRegisterList = new Collections();
                    CashRegisterList.CashRegisterList();
                }
                else if (choice == "5")
                {
                    Collections CashRegisterListDouble = new Collections();
                    CashRegisterListDouble.CashRegisterListDouble();
                }
                else if (choice == "6")
                {
                    Collections DescriptionData = new Collections();
                    DescriptionData.DescriptionData();
                }
                else if (choice == "0")
                {
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

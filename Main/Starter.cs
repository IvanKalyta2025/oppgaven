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
            Console.WriteLine("Velg en av oppgavene mine");
            Console.WriteLine("Forskjellige variabler av typene");
            Console.WriteLine("En enkel kalkulator");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                CookieBase cookes = new CookieBase();
                cookes.ShowData();
            }
        }


    }
}
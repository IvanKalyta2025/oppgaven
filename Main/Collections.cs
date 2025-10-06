using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oppgaven.Main
{
    public class Collections

    {
        public void ListSrting()
        {
            List<string> shoppingList = new List<string>
            {
                "ost",
                "brød",
                "potet",
                "milk"
            };
            string userInput;
            while (true)
            {
                Console.WriteLine("Dette er din handlelist");
                foreach (string item in shoppingList)

                    Console.WriteLine(item);

                Console.Write("Enter your item: ");
                userInput = Console.ReadLine() ?? string.Empty;

                if (shoppingList.Contains(userInput.ToLower()))
                    shoppingList.Remove(userInput.ToLower());
                else
                    shoppingList.Add(userInput.ToLower());

                if (userInput?.ToLower() == "x")
                {
                    Console.WriteLine("Tilbake til menyen...");
                    return;
                }
            }

        }

        public void CashRegisterList()
        {
            List<int> cashRegisterList = new List<int> { 3, 4, 5, 6 };

            int userInputInt;

            while (true)
            {
                Console.WriteLine("Du teller hvilke kasser som er opptatt i butikken.");
                Console.WriteLine("Klikk på x for å gå tilbake til hovedmenyen");
                foreach (int item in cashRegisterList)
                    Console.WriteLine(item);

                Console.Write("Skriv inn kassens nummer for å legge til eller fjerne den: ");
                string? userInput = Console.ReadLine();

                if (int.TryParse(userInput, out userInputInt))
                {
                    if (cashRegisterList.Contains(userInputInt))
                        cashRegisterList.Remove(userInputInt);
                    else
                        cashRegisterList.Add(userInputInt);
                }

                if (userInput?.ToLower() == "x")
                {
                    Console.WriteLine("Tilbake til menyen...");
                    return;
                }
            }
        }

        public void CashRegisterListDouble()
        {
            List<double> cashRegisterList = new List<double> { 2.323, 2329.32, 322.234, 4234.2343 };

            double userInputInt;

            while (true)
            {
                Console.WriteLine("Du teller hvilke kasser som er opptatt i butikken.");
                Console.WriteLine("Klikk på x for å gå tilbake til hovedmenyen");
                foreach (double item in cashRegisterList)
                    Console.WriteLine(item);

                Console.Write("Skriv inn kassens nummer for å legge til eller fjerne den: ");
                string? userInput = Console.ReadLine();

                if (double.TryParse(userInput, out userInputInt))
                {
                    if (cashRegisterList.Contains(userInputInt))
                        cashRegisterList.Remove(userInputInt);
                    else
                        cashRegisterList.Add(userInputInt);
                }

                if (userInput?.ToLower() == "x")
                {
                    Console.WriteLine("Tilbake til menyen...");
                    return;
                }
            }
        }
    }
}

//         public void ListDouble()
//         {
//             List<double> shoppingDouble = new List<double>
//             {
//                 2.223,
//                 3.323,
//                 4.232,
//                 5.232
//             };
//             double userInput;
//         }
//     }
// }
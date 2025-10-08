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

                Console.Write("Enter your item: \n Klikk på x for å gå tilbake til hovedmenyen\n");
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

        public void DescriptionData()
        {
            Dictionary<string, (int, double)> myDictionary = new Dictionary<string, (int, double)>(StringComparer.OrdinalIgnoreCase);
            myDictionary["Ost"] = (12, 2.12);
            myDictionary["Brød"] = (12, 2.12);
            myDictionary["Milk"] = (12, 2.12);
            myDictionary["potet"] = (12, 2.12);

            bool isFirstTime = true;
            while (isFirstTime)
            {
                Console.WriteLine("Products avaible in store:");

                //Add a function to read the Dictionary and display exactly the information we need.
                foreach (var item in myDictionary)
                {
                    Console.WriteLine($"\t{item.Key}");
                }
                //I’m testing the function for input.
                Console.Write("Skriv inn data fra listen over for å få informasjon om produktet:");
                string? input = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(input) && myDictionary.ContainsKey(input))
                {
                    Console.WriteLine($"Her er dine data: antall {myDictionary[input].Item1}, prisen {myDictionary[input].Item2}");
                }
                else
                {
                    Console.WriteLine("Produktet finnes ikke i listen eller er tomt.");
                }

                Console.Write("\nTrykk på 'x' for å gå tilbake til hovedmenyen eller Enter for å vise listen igjen:");
                string? userInput = Console.ReadLine();
                isFirstTime = false;

                if (userInput?.ToLower() == "x")
                {
                    Console.WriteLine("Tilbake til menyen...");
                }

                if (myDictionary.TryGetValue(userInput!, out var data))
                {
                    Console.WriteLine($"\nFant produktet '{userInput}':");
                    Console.WriteLine($"Antall: {data.Item1}");
                    Console.WriteLine($"Pris: {data.Item2} kr");
                    return;
                }
                else
                {
                    Console.WriteLine($"Produkt '{userInput}' finnes ikke!");
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
                Console.Write("Klikk på x for å gå tilbake til hovedmenyen");
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
            List<double> cashRegisterList = new List<double> { 2.323, 29.32, 32.234, 42.233 };

            double userInputInt;

            while (true)
            {
                Console.WriteLine("Du teller hvilke kasser som er opptatt i butikken.(klikk på x for å gå til menyen)");
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
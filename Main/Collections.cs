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
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Enter your item: ");
                userInput = Console.ReadLine() ?? string.Empty;

                if (shoppingList.Contains(userInput.ToLower()))
                    shoppingList.Remove(userInput.ToLower());
                else
                    shoppingList.Add(userInput.ToLower());
            }
        }

        public void CashRegisterList()
        {
            List<int> cashRegisterList = new List<int>
         {
            3,
                   4,
              5,
                    6
              };

            int userInputInt;

            while (true)
            {
                Console.WriteLine("Dette er din handleliste");
                foreach (int item in cashRegisterList)
                {
                    Console.WriteLine(item);
                }

                Console.Write("Enter your item: ");
                string? userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userInputInt))
                {
                    if (cashRegisterList.Contains(userInputInt))
                        cashRegisterList.Remove(userInputInt);
                    else
                        cashRegisterList.Add(userInputInt);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number!");
                }
            }
        }
    }
}
//         public void ListInt()
//         {
//             List<int> shoppingInt = new List<int>
//             {
//                 2,
//                 3,
//                 4,
//                 5
//             };
//             int userInput;
//         }
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
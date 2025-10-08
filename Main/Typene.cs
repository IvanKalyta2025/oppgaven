using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

// Variabler
// Lag forskjellige variabler av typene:
// string
// int
// double
// char
// bool
// Skriv ut disse variablene til konsollen.


//    ┌─────────────────────────────────────────┐
//    │            Cookies Pink Puppy           │
//    │ ┌───────────┐ ┌───────────┐ ┌──────────┐│
//    │ │   🍪🍪🍪   │ │   🍪🍪🍪   │ │  🍪🍪🍪   ││
//    │ └───────────┘ └───────────┘ └──────────┘│
//    │                                         │
//    └─────────────────────────────────────────┘


namespace Main
{
    public class CookieBase
    {

        string cookie_name = "Pink Puppy";
        int stock_qty = 10;
        double cookie_weight = 2.21;
        char shelf = 'N';
        bool available = true;

        public void ShowData()
        {
            Console.WriteLine($"Name: {cookie_name}, Amount: {stock_qty}, Weight: {cookie_weight} g , Location: {shelf}, Status: {available}");


            Console.WriteLine("\nTrykk på 'x' for å gå tilbake til hovedmenyen eller Enter for å vise listen igjen:");
            Console.Write("Du tok en pakke kjeks fra hyllen, oppdater dataene.\nSkriv inn nytt navn: ");
        }
        public void ShowData1()
        {
            //I add the input and output text cookie name, stock qty, shelf, available. I also need to add if... the cookie is not available, then we only get this

            string? cookie_name1 = Console.ReadLine();
            Console.WriteLine($"Oppdatert navn: {cookie_name1}");
            Console.Write("Oppdater antall (skriv et tall):");
            int? stock_qty1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Oppdatert antall:{stock_qty1}");

            //apply the base values ​​from the lines above to all methods.
            Console.Write("Oppdater hylle (skriv én bokstav):");
            string? inputShelf = Console.ReadLine();

            char? char1 = shelf;
            if (!string.IsNullOrEmpty(inputShelf))
            {
                char1 = inputShelf[0];
            }
            Console.WriteLine($"Oppdatert hylle:{char1}");
            Console.Write("Oppdater tilgjengelighet (skriv true/false):");
            //To.Lower
            bool? bool1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine($"Oppdatert tilgjengelighet:{bool1}");

            if (bool1 == false)
            {
                Console.WriteLine($"Beklager, {cookie_name1} denne pakken er tom");
                Console.Write("Trykk på 'x' for å gå tilbake til hovedmenyen eller Enter for å vise listen igjen:");

            }
            else if (bool1 == true)
            {
                Console.WriteLine($"Flott! {cookie_name1} er tilgjengeli og klar på shelf {char1} med {stock_qty1} stk igjen på lager");
                Console.Write("Trykk på 'x' for å gå tilbake til hovedmenyen eller Enter for å vise listen igjen:");
            }
            string? userInput = Console.ReadLine();

            if (userInput?.ToLower() == "x")
            {
                Console.WriteLine("Tilbake til menyen...");
            }
        }
    }
}
//добавь ввод текста после того как поулучил базовые данные 

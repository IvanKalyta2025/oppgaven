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

        public void ShowData() { Console.WriteLine($"Name: {cookie_name}, Amount: {stock_qty}, Weight: {cookie_weight} g , Location: {shelf}, Status: {available}"); }

    }
}
//добавь ввод текста после того как поулучил базовые данные 

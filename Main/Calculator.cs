using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Lag en enkel kalkulator

// Lag en klasse som heter Calculator.cs
// Lag metoder
// Add(double a, double b)
// Multiply(double a, double b)
// Subtract(double a, double b)
// Divide(double a, double b)
// Bruk gjerne if-else/switch når dere tar inn brukerinput 

namespace oppgaven.Main
{
    public interface IOperation
    {
        double Execute(double a, double b);
        string Symbol { get; }
        string Description { get; }
    }
    public class AddOperation : IOperation
    {
        public double Execute(double a, double b) => a + b;
        public string Symbol => "+";
        public string Description => "Add";
    }
    public class MultiplyOperation : IOperation
    {
        public double Execute(double a, double b) => a * b;
        public string Symbol => "*";
        public string Description => "Multiply";
    }
    public class SubtractOperation : IOperation
    {
        public double Execute(double a, double b) => a - b;
        public string Symbol => "-";
        public string Description => "Subtract";
    }
    public class DivideOperation : IOperation
    {
        public double Execute(double a, double b) => b != 0
        ? a / b
        : throw new DivideByZeroException("you can't divide by zero!");
        public string Symbol => "/";
        public string Description => "Divide";

    }
    public class Calculator
    {
        public void Run()
        {
            {
                Console.WriteLine("En enkel kalkulator");

                Console.Write("Skriv inn det første tallet: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Skriv inn det andre tallet: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("╔══════════ KALKULATOR ══════════╗");
                Console.WriteLine("║ Velg operasjon:                ║");
                Console.WriteLine("║ [1] +  (Addisjon)              ║");
                Console.WriteLine("║ [2] -  (Subtraksjon)           ║");
                Console.WriteLine("║ [3] *  (Multiplikasjon)        ║");
                Console.WriteLine("║ [4] /  (Divisjon)              ║");
                Console.WriteLine("╚════════════════════════════════╝");
                string? op = Console.ReadLine();

                double result;

                try
                {
                    switch (op)
                    {
                        case "1":
                            result = new AddOperation().Execute(a, b);
                            break;
                        case "2":
                            result = new SubtractOperation().Execute(a, b);
                            break;
                        case "3":
                            result = new MultiplyOperation().Execute(a, b);
                            break;
                        case "4":
                            result = new DivideOperation().Execute(a, b);
                            break;
                        default:
                            Console.WriteLine("Ukjent operasjon.");
                            return;
                    }

                    Console.Write($"Resultat: {result}\n");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
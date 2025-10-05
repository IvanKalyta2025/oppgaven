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

    static void Main(string[] args)
    {
        
    }
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
}
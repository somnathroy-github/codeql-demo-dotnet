using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int sum = calculator.Add(3, 4);
            Console.WriteLine($"3 + 4 = {sum}");

            int difference = calculator.Subtract(7, 4);
            Console.WriteLine($"7 - 4 = {difference}");
        }
    }
}

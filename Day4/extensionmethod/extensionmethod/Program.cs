using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            int sum = calc.Sum(5, 10);
            int subtract = calc.Subtract(10, 5);
            int multiply = calc.Multiply(5, 10); // Using the extension method
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Subtract: {subtract}");
            Console.WriteLine($"Multiply: {multiply}");
            Console.ReadLine();
        }
    }
}

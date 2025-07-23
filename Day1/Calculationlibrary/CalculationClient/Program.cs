using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculationlibrary;
namespace CalculationClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculationlibrary.Calculationlibrary obj = new Calculationlibrary.Calculationlibrary();
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Sum: " + obj.Sum(a, b));
            Console.WriteLine("Subtraction: " + obj.Sub(a, b));
            Console.WriteLine("Multiplication: " + obj.Mult(a, b));
        }
    }
}

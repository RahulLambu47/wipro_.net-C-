using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome to Wipro";
            Console.WriteLine("Length is " + str.Length);
            Console.WriteLine("Lower Case String " + str.ToLower());
            Console.WriteLine("Upper Case String " + str.ToUpper());
            Console.WriteLine("First Occurrence of Char 'o' " + str.IndexOf("o"));
            Console.WriteLine("Replaced String  " + str.Replace("Dotnet", "Dotnet Core"));
            string s1 = "Rahul", s2 = "ram", s3 = "rocky";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s1));
            Console.WriteLine(s1.CompareTo(s3));
        }
    }
}

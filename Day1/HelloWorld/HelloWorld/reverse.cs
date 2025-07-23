using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph:");
            string input = Console.ReadLine();

            string result = ReverseAlternateWords(input);
            Console.WriteLine("\nModified Paragraph:");
            Console.WriteLine(result);
        }

        static string ReverseAlternateWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return sentence;

            string[] words = sentence.Split(' ');
            for (int i = 1; i < words.Length; i += 2) // Reverse 2nd, 4th, etc.
            {
                words[i] = ReverseString(words[i]);
            }

            return string.Join(" ", words);
        }

        static string ReverseString(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
    

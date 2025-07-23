using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    internal class Case
    {
        public void Check(char choice)
        {
            switch (choice)
            {
                case 'a':
                case 'A':
                case '1':
                    Console.WriteLine("Hi I am Rahul");
                    break;
                case 'b':
                case 'B':
                case '2':
                    Console.WriteLine("Hi I am ram");
                    break;
                case 'c':
                case 'C':
                case '3':
                    Console.WriteLine("Hi I am kanth");
                    break;
                default:
                    Console.WriteLine("Invalid ");
                    break;
            }
        }
        static void Main()
        {
            char choice;
            Console.WriteLine("Enter Your Choice  ");
            choice = Convert.ToChar(Console.ReadLine());
            Case obj = new Case();
            obj.Check(choice);
        }
    }
}


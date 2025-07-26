using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticex
{
    internal class staticmeth
    {
        public void Show()
        {
            Console.WriteLine("Show Method from Class Data...");
        }

        public static void Display()
        {
            Console.WriteLine("Display Method from Class Data...");
        }
    }
    internal class StaticMethodEx1
    {
        static void Main()
        {
            staticmeth.Display();
            new staticmeth().Show();
        }
    }
}
    

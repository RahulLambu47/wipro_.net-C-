using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticex
{
    static class Program
    {
        public static void Show()
        {
            Console.WriteLine("Show Method from Demo Class...");
        }

        public static string Trainer()
        {
            return "Trainer is Prasanna P";
        }
    }


    internal class StaticClassEx1
    {
        static void Main()
        {
            Program.Show();
            Console.WriteLine(Program.Trainer());
        }
    }
}

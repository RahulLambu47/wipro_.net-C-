using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1[] arr = new Interface1[]
            {
                new rahul(), new sai()
            };

            foreach (Interface1 i in arr)
            {
                i.Name();
                i.Email();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3; 

           
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(~a);
            Console.WriteLine(~b);
        } 
    }
}

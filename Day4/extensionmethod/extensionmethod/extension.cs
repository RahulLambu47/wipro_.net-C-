using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethod
{
    internal static class extension
    {
        public static int Multiply(this Calculation calc, int a, int b)
        {
            return a * b;
        }
    }
}

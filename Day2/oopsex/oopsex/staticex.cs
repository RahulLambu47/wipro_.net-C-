using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsex
{
    internal class staticex
    {
        static int count;
        public void Increment()
        {
            count++;
        }
        public void Show()
        {
            Console.WriteLine("Count f static variable is: " + count);
        }
        public static void Main(string[] args)
        {
            staticex obj1 = new staticex();
            staticex obj2 = new staticex();
            staticex obj3 = new staticex();
            obj1.Increment();
            obj2.Increment();
            obj3.Increment();
            obj1.Show(); // Output: Count of static variable is: 3
            obj2.Show(); // Output: Count of static variable is: 3
            obj3.Show(); // Output: Count of static variable is: 3  

        }
    }
}

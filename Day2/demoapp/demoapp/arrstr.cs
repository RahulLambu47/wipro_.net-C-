using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    internal class arrstr
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Rahul","harish","ram","liks","anu"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        static void Main()
        {
            arrstr arrayStr = new arrstr();
            arrayStr.Show();
        }
    }
}
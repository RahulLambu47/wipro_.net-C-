using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    internal class array
    {
        public void Show()
        {
            int[] a = new int[] { 1, 2, 45, 7, 9 };
           
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Main()
        {
            array obj = new array();
            obj.Show();
        }
    }
}
    

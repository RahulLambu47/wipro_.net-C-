using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Training obj1 = new Rajesh();
            //Training obj2 = new Venkat();
            //Training obj3 = new Mahi();

            //int[] a =new int[] { 1, 2, 3, 4 };

            training[] arrTraining = new training[]
            {
                new Rahul(),
                new Sai(),
               
            };

            foreach (training t in arrTraining)
            {
                t.Company();
                t.Email();
                t.Name();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}

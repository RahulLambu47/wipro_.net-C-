using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoapp
{
    internal class boxemploy
    {
        public void Show(object obj)
        {
            string type = obj.GetType().Name;
            if (type.Equals("Employ"))
            {
                Employ employ = (Employ)obj;
                Console.WriteLine("Employ No  " + employ.empno + " Name " + employ.name + " Basic " + employ.basic);
            }
        }
        static void Main()
        {
            Employ employ = new Employ();
            employ.empno = 1;
            employ.name = "Rahul";
            employ.basic = 10000;

            boxemploy boxEmploy = new boxemploy();
            boxEmploy.Show(employ);
        }
    }
}
    

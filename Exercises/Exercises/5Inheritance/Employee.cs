using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._5Inheritance
{
    internal class Employee : Person, IPayable
    {
        public void GetPaid()
        {
            Console.WriteLine("Paying salary");
        }
    }
}

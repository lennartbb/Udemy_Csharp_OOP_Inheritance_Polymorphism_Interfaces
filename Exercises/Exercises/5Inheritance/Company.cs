using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._5Inheritance
{
    internal class Company : IPayable
    {
        public void GetPaid()
        {
            Console.WriteLine("Paying invoice");
        }
    }
}

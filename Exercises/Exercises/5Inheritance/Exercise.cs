using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._5Inheritance
{
    internal class Exercise
    {
        public static void Start() 
        {
            Employee foo = new Employee(); 
            Company baz = new Company();

            Pay(foo);
            Pay(baz);
        }


        public static void Pay(IPayable payable)
        {
            payable.GetPaid(); 
        }
    }
}

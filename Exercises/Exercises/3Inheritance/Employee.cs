using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    class Employee : Person
    {
        public Employee(string name, string department) : base(name)
        {
            Department = department;
        }

        public string Department { get; set; }
    }
}

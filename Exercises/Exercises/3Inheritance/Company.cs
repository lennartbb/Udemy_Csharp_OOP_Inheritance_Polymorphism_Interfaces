using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    class Company
    {
        public Company(string name)
        {
            Name = name;
                    }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Consultant> Consultants { get; set; } = new List<Consultant>();
    }
}

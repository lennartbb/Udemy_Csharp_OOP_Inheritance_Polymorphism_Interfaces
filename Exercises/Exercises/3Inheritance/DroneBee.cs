using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    class DroneBee : Bee
    {
        public DroneBee(string name) : base(name)
        {            
        }
        public int HoneyCount { get; set; }
    }
}

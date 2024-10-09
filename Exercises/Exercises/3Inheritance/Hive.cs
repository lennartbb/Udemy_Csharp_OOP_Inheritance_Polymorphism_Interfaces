using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    internal class Hive
    {
        public Hive(QueenBee queen)
        {
            Queen = queen;
            Drones = new List<DroneBee>();
        }
        public QueenBee Queen { get; set; }
        public List<DroneBee> Drones { get; set; } 
    }
}

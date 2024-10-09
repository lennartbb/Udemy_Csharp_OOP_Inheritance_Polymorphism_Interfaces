using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._4Polymorphism
{
    internal class Boat : Vehicle
    {
        public Boat()
        {
        }
        public override string ToString()
        {
            return "Boat";
        }
        public override void Stop()
        {
            Console.WriteLine("Docking boat");
        }
    }
}

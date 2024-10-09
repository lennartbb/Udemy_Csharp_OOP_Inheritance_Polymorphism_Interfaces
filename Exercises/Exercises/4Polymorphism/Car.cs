using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._4Polymorphism
{
    internal class Car : Vehicle
    {
        public Car()
        {
        }
        public override string ToString()
        {
            return "Car";
        }
        public override void Stop()
        {
            Console.WriteLine("Parking car");
        }
        
            
    }
}

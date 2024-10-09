using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._4Polymorphism
{
    internal class Rocket : Vehicle
    {
        public Rocket() 
        {
        }
        public override string ToString()
        {
            return "Rocket";
        }
        public override void Start()
        {
            Console.WriteLine("Launching in");
            for (int i = 3; i >= 0; i--)
            {
                Console.WriteLine(i.ToString());
                Thread.Sleep(1000);
            }
                base.Start();
        }
        public override void Stop() 
        {
            Console.WriteLine("Landing rocket"); 
        }
    }
}

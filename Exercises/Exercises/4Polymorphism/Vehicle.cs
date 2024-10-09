using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._4Polymorphism
{
    internal abstract class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine($"Starting: {this}");
            Console.WriteLine($"{this} started");
        }
        public abstract void Stop();


    }
}

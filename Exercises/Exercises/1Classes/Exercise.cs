using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
    class Exercise
    {
        public static void Start()
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Exercise 1");

            Console.WriteLine("Exercise 2.");

            Musician musician1 = new Musician("Svend", new Guitar(Brand.Fender, 2000));
            Musician musician2 = new Musician("Lasse", new Guitar(Brand.Gibson, 1100));

            musician1.Play();
            musician2.Play();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
    class Musician
    {
        public Musician(string name, Guitar guitar)
        {
            Name = name;
            Guitar = guitar;
        }

        public void Play()
        {
            Console.WriteLine($"{Name} spiller på {Guitar.Brand} og den koster {Guitar.Price}");
        }
        public string Name { get; set; }
        public Guitar Guitar{ get; set; }
    }
    
}

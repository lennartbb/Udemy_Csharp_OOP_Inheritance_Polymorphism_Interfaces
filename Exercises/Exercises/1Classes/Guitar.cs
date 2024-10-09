using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._1Classes
{
     class Guitar
    {
        public Guitar(Brand brand, int price)
        {
            Brand = brand;
            Price = price;
        }
        public Brand Brand { get; set; }
        public int Price { get; set; }
    }
    enum Brand
    {
        Fender,
        Gibson,
        Ibanez, 
    }
}

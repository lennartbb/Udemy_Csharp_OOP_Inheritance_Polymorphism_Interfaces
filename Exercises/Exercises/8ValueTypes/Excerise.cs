using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._8ValueTypes
{
    public class Excerise
    {
        public static void Start()
        {
            House ourHouse = new House("fooStreet", 6);
            Console.WriteLine(ourHouse.ToString());
            UpdateHouse(ourHouse);
            Console.WriteLine(ourHouse.ToString());


        }

        static void UpdateHouse(House house)
        {
            house.Address = "Address not found";
            house.NumberOfWindows = 0;
        }

    }
}

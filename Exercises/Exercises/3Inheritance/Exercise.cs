using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._3Inheritance
{
    class Exercise
    {
        public static void Start()
        {
            Consultant bob = new Consultant("Bob", 1000, 80);
            Consultant dave = new Consultant("Dave", 850, 120);
            Employee rob = new Employee("Rob", "R&D");
            Employee becca = new Employee("Becca", "HR");

            Company evilCorp = new Company("EvilCorp");

            evilCorp.Employees.Add(rob);
            evilCorp.Employees.Add(becca);
            evilCorp.Consultants.Add(dave);
            evilCorp.Consultants.Add(bob);

            Hive bHive = new Hive(new QueenBee("Beyonce"));
            bHive.Drones.Add(new DroneBee("B1"));
            bHive.Drones.Add(new DroneBee("B2"));
            bHive.Drones.Add(new DroneBee("B3"));
            bHive.Drones.Add(new DroneBee("B4"));
            bHive.Drones.Add(new DroneBee("B5"));
            bHive.Drones.Add(new DroneBee("B6"));
            bHive.Drones.Add(new DroneBee("B7"));
            bHive.Drones.Add(new DroneBee("B8"));
            bHive.Drones[0].HoneyCount = 1;
            bHive.Drones[1].HoneyCount = 11;
            bHive.Drones[2].HoneyCount = 12;
            bHive.Drones[3].HoneyCount = 13;
            bHive.Drones[4].HoneyCount = 14;
            bHive.Drones[5].HoneyCount = 15;
            bHive.Drones[6].HoneyCount = 16;




        }
    }
}

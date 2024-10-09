using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises._4Polymorphism
{
    internal class Exercise
    {
        public static void Start()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Rocket());
            vehicles.Add(new Car());
            vehicles.Add(new Boat());
/*
            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
            }
            foreach (var vehicle in vehicles)
                vehicle.Stop();
*/
            List<Person> persons = new List<Person>(); 
            persons.Add(new Consultant("Foo" ,10));
            persons.Add(new Employee("Bar"));
            Consultant Baz = new Consultant("Baz", 10);
            Baz.HoursWorked = 10;
            Baz.HourlyRate = 1250;
            persons.Add(Baz);

            foreach (Person person in persons)
            {
                Pay(person);
            }
            
        }

        static void Pay(Person person)
        {
            person.GetPaid();
        }
    }
    abstract class Person
    {
        protected Person(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }

        public abstract void GetPaid();



  
    }

    class Employee : Person
    {
        public Employee(string name) : base(name)
        {
            Salary = 100;
        }
        public int Salary { get; set; }
        public override void GetPaid()
        {
            Console.WriteLine($"The employee {Name} is paid {Salary}");
        }

    }

    class Consultant : Person
    {
        public Consultant(string name, int hoursWorked) : base(name)
        {
            HoursWorked = hoursWorked;
            HourlyRate = 1000;
        }
        public int HoursWorked { get; set; } 
        public int HourlyRate { get; set; }
        public override void GetPaid()
        {
            Console.WriteLine($"The consultant {Name} is paid {HoursWorked * HourlyRate} for {HoursWorked} hours worked");
        }

    }

}

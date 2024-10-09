using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Animal : IEdible
    {
        public Animal(double weight)
        {
            Weight = weight;
            Makesound();
        }
        public double Weight { get; set; }
        
        public virtual void Eat(IEdible Edible)
        { 
            this.Weight += Edible.Weight;
        }

        public abstract void Makesound();
    }

    class Cat : Animal
    {
        public Cat() : base(4.5)
        {
        }
        public override void Makesound()
        {
            Console.WriteLine("Miav");
        }
    }
    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
        }
        public override void Eat(IEdible animalToEat)
        {
            this.Weight += animalToEat.Weight * 0.8;
        }

        public override void Makesound()
        {
            Console.WriteLine("Bark");
        }
    }
    class Grass : IEdible
    {
        public Grass(double weight)
        {
            Weight = weight;
        }
        public double Weight { get; set; }
    }

    interface IEdible
    {
        public double Weight { get; }
    }

}

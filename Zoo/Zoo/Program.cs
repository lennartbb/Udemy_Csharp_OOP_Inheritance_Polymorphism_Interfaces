using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog(100);
 
            List<Animal> animals = new List<Animal>(); 
            animals.Add(dog);
            animals.Add(cat);

            foreach (var animal in animals)
            {               
                animal.Eat(new Grass(15));
                Console.WriteLine(animal.Weight);
            }

        }
    }
}
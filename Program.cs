using System;
using System.Collections.Generic;
using Interfaces_AbstractClasses.Interface;

namespace Interfaces_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            List<IMammal> ammals = new List<IMammal>();
            List<IFish> fishs = new List<IFish>();

            animals.Add(new Cat("Murka"));
            animals.Add(new Dog("Amsius"));
            animals.Add(new BassFish("Zuviukas Nemo"));
            animals.Add(new CarpFish("Karpiukas"));

            ammals.Add(new Cat("Pukis"));
            ammals.Add(new Dog("Ryzikas"));

            fishs.Add(new CarpFish("Karpis"));
            fishs.Add(new BassFish("Eserys"));

            animals.ForEach(animal => animal.Eat());

            ammals.ForEach(ammals => ammals.GiveBirth());

            fishs.ForEach(fish => fish.Swim());

            Dog dog1 = new Dog("Daumanto suniukas");
            Dog dog2 = new Dog("Daumanto suniukas");

            if (dog1.CompareTo(dog2) == 0)
            {
                Console.WriteLine("vardai sutampa");
            }
            else
            {
                Console.WriteLine("vardai nesutampa");
            }
        }
    }
}

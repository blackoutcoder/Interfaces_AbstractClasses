using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces_AbstractClasses.Interface;

namespace Interfaces_AbstractClasses
{
    internal class Dog : IMammal, IAnimal, IComparable<Dog>
    {
        string Name { get; }
        public Dog(string name)
        {
            Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Im dog, im eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Im dog, im giv birth");

        }

        public int CompareTo(Dog other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces_AbstractClasses.Interface;

namespace Interfaces_AbstractClasses
{
    internal class Cat : IMammal, IAnimal, IComparable<Cat>
    {
        public string Name { get; }
        public Cat(string name)
        {
            Name = name;
        }
        public int CompareTo(Cat other)
        {
            return Name.CompareTo(other.Name);
        }

        public void Eat()
        {
            Console.WriteLine("Im cat, im eating");
        }

        public void GiveBirth()
        {
            Console.WriteLine("Im cat, im giving birth");

        }
    }
}

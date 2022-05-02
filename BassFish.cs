using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces_AbstractClasses.Interface;

namespace Interfaces_AbstractClasses
{
    internal class BassFish : IFish, IAnimal, IComparable<BassFish>
    {
        string Name { get; }

        public BassFish(string name)
        {
            Name = name;
        }

        public int CompareTo(BassFish other)
        {
            return Name.CompareTo(other.Name);
        }

        public void Eat()
        {
            Console.WriteLine("I'am a Bass fish, i'm eating");
        }

        public void Swim()
        {
            Console.WriteLine("I'm Bass fish, i'm swiming");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces_AbstractClasses.Interface;

namespace Interfaces_AbstractClasses
{
    internal class CarpFish : IAnimal, IFish, IComparable<CarpFish>
    {
        string Name { get; }

        public CarpFish(string name)
        {
            Name = name;
        }
        public int CompareTo(CarpFish other)
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            Console.WriteLine("Im Carp, im eating");
        }

        public void Swim()
        {
            Console.WriteLine("Im Carp, im swiming");

        }
    }
}

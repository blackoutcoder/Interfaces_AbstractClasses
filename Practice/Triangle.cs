using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Interface;

namespace Practice
{
    public class Triangle : IPolygon 
    {
        public double Base { get; }
        public double High { get; }
        public Triangle(double basse, double high)
        {
            Base = basse;
            High = high;
        }
        public double GetArea()
        {
            return Base * High / 2;
        }
    }
}

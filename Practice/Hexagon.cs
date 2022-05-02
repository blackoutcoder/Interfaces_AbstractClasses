using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Interface;

namespace Practice
{
    public class Hexagon : IPolygon, IComparable<Hexagon>
    {
        public double Krastine { get; }
        public Hexagon(double krastine)
        {
            Krastine = krastine;
        }
        public double GetArea()
        {
            return 6.0 / 4.0 * Math.Pow(Krastine, 2) *  Math.Tan(60);
        }

        public int CompareTo(Hexagon other)
        {
            double currentArea = GetArea();
            double otherArea = other.GetArea();
            return currentArea.CompareTo(otherArea);
        }
    }
}

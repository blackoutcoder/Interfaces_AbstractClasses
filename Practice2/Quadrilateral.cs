using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice2.Interface;

namespace Practice2
{
    public class Quadrilateral : IPolygon
    {
        public double Izambyne { get; }
        public double Aukstine1 { get; }
        public double Aukstine2 { get; }
        public Quadrilateral(double izambine, double aukstine1, double aukstine2)
        {
            Izambyne = izambine;
            Aukstine1 = aukstine1;
            Aukstine2 = aukstine2;
        }
        public double GetArea()
        {
            return Izambyne * Aukstine1 * Aukstine2;
        }
    }
}

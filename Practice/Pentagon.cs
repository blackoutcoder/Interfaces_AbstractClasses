using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.Interface;

namespace Practice
{
    public class Pentagon : IPolygon
    { 
        public double Spindulys { get; }
        public Pentagon(double spindulys)
        {
            Spindulys = spindulys;
        }
        public double GetArea()
        {
            return 5 / 2.0 * Math.Pow(Spindulys, 2) * Math.Sin(72);
        }
    }
}

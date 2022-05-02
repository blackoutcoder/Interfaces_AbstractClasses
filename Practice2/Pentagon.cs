using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice2.Interface;

namespace Practice2
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
        public void WriteToFile(string filename)
        {
            string result = ToString();
            File.AppendAllText(filename, result);
        }

        public override string ToString()
        {
            return $"Penkiakampio, kurio plotas {GetArea()}";
        }
    }
}

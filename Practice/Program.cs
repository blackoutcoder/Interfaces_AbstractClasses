using System;
using Practice.Interface;
using System.Collections.Generic;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPolygon> iPolygonList = new List<IPolygon>()
            {
                new Triangle(1.0, 2.0),
                new Quadrilateral(1.0, 2.0, 2.0),
                new Pentagon(2.0),
                new Hexagon(2.0)
            };

            iPolygonList.ForEach(iPolygonList =>
            {
                double area = iPolygonList.GetArea();
                Console.WriteLine(area);
            });
            Hexagon hexagon1 = new Hexagon(3.0);
            Hexagon hexagon2 = new Hexagon(3.0);

            var result = hexagon1.CompareTo(hexagon2);
            if (result == 0)
            {

            }
        }

    }
}

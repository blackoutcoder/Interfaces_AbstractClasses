using System;
using Practice2.Interface;
using System.Collections.Generic;


namespace Practice2
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

            iPolygonList.ForEach(polygon =>
            {
                string content = polygon.ToString();
                Console.WriteLine(content);

                
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace snap_lab_struct
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
           List<Point> points = new List<Point>();

            var p01 = new Point(3, 5);
            var p02 = new Point(7, 11);
            var p03 = new Point(27, 4);

            points.Add(p01);
            points.Add(p02);
            points.Add(p03);
            List<int> Xvalues = new List<int>();
            List<int> Yvalues = new List<int>();

            foreach(var num in points)
            {
                Xvalues.Add(num.X);
                Yvalues.Add(num.Y);



            }

            int xMax = (Xvalues.ToArray().Max());
            int yMax = (Yvalues.ToArray().Max());
            int xMin = (Xvalues.ToArray().Min());
            int yMin = (Yvalues.ToArray().Min());

            int xRange = xMax - xMin;
            int yRange = yMax - yMin;

            Console.WriteLine($"xMax: {xMax}");
            Console.WriteLine($"xMin: {xMin}");
            Console.WriteLine($"yMax: {yMax}");
            Console.WriteLine($"yMin: {yMin}");

            Console.WriteLine($"xRange : {xRange}");
            Console.WriteLine($"yRange : {yRange}");
        }
    }

    public struct Point
    {
        public int X;
        public int Y;

        public Point (int x, int y)
        {
            this.X = x;
            this.Y = y;
            
        }
    }

    /*Create a struct point with x,y

    list<point> points
    create 3 points and add to list
    loop over collection
    find highest x value & highest y value
    bonus lowest also*/
}

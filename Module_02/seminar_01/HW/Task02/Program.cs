using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var p1 = new Point(rnd.Next(1,100), rnd.Next(-100,1), "first point");
            var p2 = new Point(rnd.Next(-51,0), rnd.Next(0,51), "second point");
            var p3 = new Point(rnd.Next(-100, 100), rnd.Next(-100, 100), "third point");
            var dict = new Dictionary<double, string>(3);
            dict.Add(p1.R, p1.Name);
            dict.Add(p2.R, p2.Name);
            dict.Add(p3.R, p3.Name);
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in dict)
            {
                if (item.Value == "first point")
                    Point.PrintData(p1);
                if (item.Value == "second point")
                    Point.PrintData(p2);
                if (item.Value == "third point")
                    Point.PrintData(p3);
            }



        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public string Name { get; set; }

        public Point(double x, double y, string name) { (X, Y, Name) = (x, y, name); }

        public Point() { (X, Y, Name) = (0, 0, "None"); }

        public double R { get { return CalcR(); } }

        public double F { get { return CalcF(); } }

        private double CalcR() => Math.Sqrt(Y * Y + X * X);

        private double CalcF()
        {
            if (X > 0 && Y >= 0)
                return Math.Atan(Y / X);
            else if (X > 0 && Y < 0)
                return Math.Atan(Y / X) + 2 * Math.PI;
            else if (X < 0)
                return Math.Atan(Y / X) + Math.PI;
            else if (Y > 0 && X == 0)
                return Math.PI / 2;
            else if (X == 0 && Y < 0)
                return 1.5 * Math.PI;
            else if (X == 0 && Y == 0)
                return 0;
            return 0;
        }

        public static void PrintData(Point point) => Console.WriteLine($"x: {point.X}\ty: {point.Y}\tr: {point.R}\tf: {point.F}");

        }
}
using System;
using System.Threading.Channels;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point2D();
            Console.WriteLine(point1.X);
            Console.WriteLine(point1.Y);
            var point2 = new Point2D();
            (point2.X, point2.Y) = (5, 5);
            Point2D.PrintPoint(point2);
            var point3 = new Point2D(3, 3);
            Point2D.PrintPoint(point3);
            Console.WriteLine(point1.Distance());
            Console.WriteLine(point2.Distance(point3));
            Point2D.PrintPoint(point3+point2);
            Point2D.PrintPoint(point3+1);
            Point2D.PrintPoint(1+point2);
            Point2D.PrintPoint(point3-point2);
            Console.WriteLine(point1.ToString());


        }
    }

    class Point2D
    {
        public Point2D() {}

        public Point2D(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        
        
        public int X { get; set; }

        public int Y { get; set; }

        public static void PrintPoint(Point2D point)
        {
            Console.WriteLine($"{point.X} {point.Y}");
        }

        public double Distance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        
        public double Distance(Point2D point)
        {
            return Math.Sqrt((X-point.X) * (X-point.X) + (Y-point.Y * (Y-point.Y)));
        }
        
        public static Point2D operator+(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }
        
        public static Point2D operator-(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }
        
        public static Point2D operator+(int val, Point2D point)
        {
            return new Point2D(val + point.X, val + point.Y);
        }
        
        public static Point2D operator+(Point2D point, int val)
        {
            return new Point2D(val + point.X, val + point.Y);
        }

        public override string ToString()
        {
            return X + " " + Y;
        }
    }
}
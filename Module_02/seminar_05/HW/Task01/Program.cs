using System;

namespace Task01
{
    internal class Program
    {
        private static void Main()
        {
            var r = new Random();
            var n1 = r.Next(3, 6);
            var n2 = r.Next(3, 6);
            var n3 = r.Next(3, 6);

            var shapes = new Shape[n1 + n2 + n3];

            for (var i = 0; i < n1; i++)
            {
                var rad = r.Next(0,100);
                shapes[i] = new Circle(rad);
                Print(shapes[i]);
            }
            
            for (var i = n1; i < n1+n2; i++)
            {
                var rad = r.Next(0,100);
                r = new Random();
                var heig = r.Next(0, 100);
                shapes[i] = new Cylinder(rad,heig);
                Print(shapes[i]);
            }
            
            for (var i = n1+n2; i < n1+n2+n3; i++)
            {
                var rad = r.Next(0,100);
                shapes[i] = new Sphere(rad);
                Print(shapes[i]);
            }
        }

        private static void Print(Shape shape)
        {
            if (shape is Circle) Console.Write("Круг, имеющий ");
            else if (shape is Cylinder) Console.Write("Цилиндр, имеющий ");
            else Console.Write("Сфера, имеющая ");
            Console.WriteLine(shape+"\n"); 
        }
    }
    
    internal abstract class Shape
    { 
        protected double Radius { get; }

        protected Shape(double radius)
        {
            Radius = radius;
        }

        protected abstract double Area();
        
        public override string ToString()
        {
            return $"площадь = {Area():0.000}";
        }
    }
    
    internal class Circle : Shape
    {

        public Circle(double radius) : base(radius) { }
        
        protected override double Area()
        {
            return 2 * Math.PI * Radius;
        }
    }

    internal class Cylinder : Shape
    {
        private double Height { get; }
        
        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }
        protected override double Area()
        {
            return 2 * Math.PI* Radius * (Radius + Height);
        }
    }
    
    internal class Sphere : Shape
    {
        public Sphere(double radius) : base(radius) { }

        protected override double Area()
        {
            return 4 * Math.PI * Radius * Radius;
        }
    }
}
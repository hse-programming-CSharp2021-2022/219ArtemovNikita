using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            var pol = new RegularPolygon(6, 10);
            RegularPolygon.PolygonData(pol);
        }
    }

    internal class RegularPolygon
    {
        public RegularPolygon()
        {
            SidesCount = 1;
            Radius = 0;
        }
        
        public RegularPolygon(int sides, double radius)
        {
            SidesCount = sides;
            Radius = radius;
        }
        
        public int SidesCount { get; set; }
        public double Radius { get; set; }

        public double Perimetr
        {
            get { return CalcPerimetr(); }
        }

        public double Area
        {
            get { return CalcArea(); }
        }

        private double CalcPerimetr()
        {
            return SidesCount * 2 * Radius * Math.Sin((Math.PI / 2) / SidesCount);
        }

        private double CalcArea()
        {
            return Radius * Radius * SidesCount * Math.Tan((Math.PI / 2) / SidesCount);
        }

        public static void PolygonData(RegularPolygon pol)
        {
            Console.WriteLine($"Количество сторон: {pol.SidesCount}\n" +
                              $"Радиус: {pol.Radius}\n" +
                              $"Периметр: {pol.Perimetr}\n" +
                              $"Площадь: {pol.Area}");
        }
    }
}
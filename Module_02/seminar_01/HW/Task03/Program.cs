using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03
{
    class Program
    {
        // Оставил вывод информации о многоугольниках после ввода всех данных, чтобы сохранить окрашивание площадей.
        static void Main(string[] args)
        {
            var polygons = new List<RegularPolygon>();
            var area = new List<double>();
            var j = 0;
            while(true)
            {
                Console.Write($"enter count of sides of {j+1} polygon: ");
                var sides = int.Parse(Console.ReadLine());
                Console.Write($"enter radius of {j+1} polygon: ");
                var rad = double.Parse(Console.ReadLine());
                polygons.Add(new RegularPolygon(sides, rad));
                area.Add(polygons[j].Area);
                if (rad == 0 || sides == 0)
                    break;
                j++;
            }

            var n = polygons.Count;
            for (var i = 0; i < n; i++)
            {
                if (area[i] == area.Min())
                {
                    Console.Write($"{i+1} polygon data: ");
                    RegularPolygon.GreenPolygonData(polygons[i]);
                }
                else if (area[i] == area.Max())
                {
                    Console.Write($"{i+1} polygon data: ");
                    RegularPolygon.RedPolygonData(polygons[i]);
                }
                else
                {
                    Console.Write($"{i+1} polygon data: ");
                    RegularPolygon.PolygonData(polygons[i]);
                }
            }
        }
    }

    internal class RegularPolygon
    {
        public RegularPolygon()
        {
            SidesCount = 0;
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
            if (SidesCount == 0 || SidesCount == 1)
                return 0;
            return SidesCount * 2 * Radius * Math.Sin((Math.PI / 2) / SidesCount);
        }

        private double CalcArea()
        {
            if (SidesCount == 0 || SidesCount == 1)
                return 0;
            return Radius * Radius * SidesCount * Math.Tan((Math.PI / 2) / SidesCount);
        }

        public static void PolygonData(RegularPolygon pol)
        {
            Console.WriteLine($"Количество сторон: {pol.SidesCount}; " +
                              $"Радиус: {pol.Radius}; " +
                              $"Периметр: {pol.Perimetr}; " +
                              $"Площадь: {pol.Area}");
        }

        public static void GreenPolygonData(RegularPolygon pol)
        {
            Console.Write($"Количество сторон: {pol.SidesCount}; " +
                              $"Радиус: {pol.Radius}; " +
                              $"Периметр: {pol.Perimetr}; ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Площадь: {pol.Area}");
            Console.ResetColor();
        }
        
        public static void RedPolygonData(RegularPolygon pol)
        {
            Console.Write($"Количество сторон: {pol.SidesCount}; " +
                              $"Радиус: {pol.Radius}; " +
                              $"Периметр: {pol.Perimetr}; ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Площадь: {pol.Area}");
            Console.ResetColor();
        }
    }
}
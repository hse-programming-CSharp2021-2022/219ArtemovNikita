using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter radius: ");
            double R;
            while (!double.TryParse(Console.ReadLine(), out R))
            {
                Console.Write("enter correct radius: ");
            }
            double L = 2 * Math.PI * R, S = getarea(R);
            Console.WriteLine("length of circle is " + L.ToString("0.000"));
            Console.WriteLine("area of circle is " + S.ToString("0.000"));

        }

        public static double getarea(double R)
        {
            double area = Math.PI * R * R;
            return area;
        }

    }
}
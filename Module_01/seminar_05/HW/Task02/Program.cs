using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine(S1(x));
                Console.WriteLine(S2(x));
            }
        }

        static ulong f(ulong x)
        {
            if (x <= 1)
                return 1;
            else
                return x * f(x - 1);
        }
        
        static double S1(double x)
        {
            double s = x * x;
            double s1 = 0;
            ulong degree = 3;
            while (Math.Abs(s1 - s) > 0.000000000000001)
            {
                s1 = s;
                s += Math.Pow(-1, degree) * (Math.Pow(2, degree) * Math.Pow(x, degree + 1)) / f(degree + 1);
                degree += 2;
            }
            return s;
        }

        static double S2(double x)
        {
            double s = 1;
            double s1 = 0;
            ulong n = 1;
            while (Math.Abs(s1 - s) > 0.000000000000001)
            {
                s1 = s;
                s += Math.Pow(x, n) / f(n);
                n++;
            }
            return s;
        }
    }
}
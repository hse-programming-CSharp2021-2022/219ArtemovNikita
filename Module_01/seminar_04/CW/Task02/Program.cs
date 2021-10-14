using System;
namespace Task2
{
    class Program
    {
        static void Sum(int n)
        {
            double s = 0;
            for(int i = 1; i <= n; ++i)
            {
                double buff = (i + 0.3) / (3 * i * i + 5);
                Console.WriteLine(buff);
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Sum(n);
        }
    }
}
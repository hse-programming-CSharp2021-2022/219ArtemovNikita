using System;

namespace Task01
{
    class Program
    {
        static double[] sinarr(int N)
        {
            double[] arr = new double[N];
            for (int i = 0; i < N; i++)
            {
                double cursum;
                double sum = 0;
                int j = 1;
                do
                {
                    cursum = sum;
                    sum +=
                } while (cursum != sum);

                arr[i] = sum;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //MinMax(12345);
            int val = 10;
            Console.WriteLine(val);
            add(val);
            Console.WriteLine(val);
            add(ref val);
            Console.WriteLine(val);
            add(out val, 10, 20, 30);
            Console.WriteLine(val);
            int min, max;
            MinMax(1234, out min, out max);
            Console.WriteLine(min);
            Console.WriteLine(max);
        }

        public static void MinMax(int a, out int MinValue, out int MaxValue)
        {
            MinValue = 10;
            MaxValue = -1;
            int next;
            while (a > 0)
            {
                next = a % 10;
                a /= 10;
                if (MinValue > next) MinValue = next;
                if (MaxValue < next) MaxValue = next;
            }
            Console.WriteLine(MinValue);
            Console.WriteLine(MaxValue);
        }

        public static void add(int a)
        {
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
        }
        public static void add(ref int a)
        {
            Console.WriteLine(a);
            a += 10;
            Console.WriteLine(a);
        }
        public static void add(out int sum, params int[] a)
        {
            sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
        }
    }
}

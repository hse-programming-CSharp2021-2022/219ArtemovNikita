using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            Random rnd = new Random();
            int N;
            for (int i = 0; i < arr.Length; i++)
            {
                N = rnd.Next(5, 16);
                arr[i] = new int[N];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(-10, 11);
                }
                Array.ForEach(arr[i], el => Console.Write(el + " "));
                Console.WriteLine();
            }
            Console.WriteLine("Исходный массивы выведены, теперь идем дальше");
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
                Array.Reverse(arr[i]);
            }
            Array.Sort(arr,Count);
            for (int i = 0; i < arr.Length; i++)
            {
                Array.ForEach(arr[i],el => Console.Write(el + " "));
                Console.WriteLine();
            }

            Console.WriteLine("done");
        }

        static int Count(int[] a, int[] b)
        {
            int ca = a.Length;
            int cb = b.Length;
            if (ca > cb)
                return -1;
            if (ca < cb)
                return 1;
            return 0;
        }
    }
}
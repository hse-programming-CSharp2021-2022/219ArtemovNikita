using System;
using System.ComponentModel;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1000, 10000);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            int[] p = Array.FindAll(arr, pal);
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);
            }
        }

        static bool pal(int a)
        {
            int[] arr = new int[4];
            arr[0] = a % 10;
            arr[1] = (a / 10) % 10;
            arr[2] = (a / 100) % 10;
            arr[3] = (a / 1000) % 10;
            if (arr[0] == arr[3] && (arr[1] == arr[2]))
                return true;
            else
            {
                return false;
            }
        }
    }
}
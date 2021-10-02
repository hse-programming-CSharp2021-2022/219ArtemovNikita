using System;
using System.ComponentModel;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0,1001);
            }
            Array.Sort(arr,ev);
            Array.ForEach(arr,el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(arr,count);
            Array.ForEach(arr,el => Console.Write(el + " "));
            Console.WriteLine();
            Array.Sort(arr,sum);
            Array.ForEach(arr,el => Console.Write(el + " "));
        }

        static int ev(int a, int b)
        {
            if (a % 2 == 0 && b%2!=0)
                return -1;
            if (a % 2 == 1 && b%2==0)
                return 1;
            return 0;
        }

        static int count(int a, int b)
        {
            int lenA = a.ToString().Length;
            int lenB = b.ToString().Length;
            if (lenA > lenB)
                return -1;
            if (lenA < lenB)
                return 1;
            return 0;
        }

        static int sum(int a, int b)
        {
            int suma = 0;
            int sumb = 0;

            while (a > 0)
            {
                suma += a % 10;
                a /= 10;
            }
            while (b > 0)
            {
                sumb += b % 10;
                b /= 10;
            }

            if (suma < sumb)
                return 1;
            if (sumb < suma)
                return -1;
            return 0;
        }
    }
}
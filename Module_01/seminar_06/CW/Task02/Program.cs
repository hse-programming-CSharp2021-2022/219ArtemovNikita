using System;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int s1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i+1;
                s1 += arr[i];
            }
            Shuffle(arr);
            Array.Resize(ref arr,99);
            int s2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                s2 += arr[i];
            }
            Console.WriteLine(s1-s2);
        }

        static void Shuffle(int[] arr)
        {
            Random rand = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                int a = arr[j];
                arr[j] = arr[i];
                arr[i] = a;
            }
        }
    }
}
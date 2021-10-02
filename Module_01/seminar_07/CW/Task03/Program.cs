using System;

namespace Task03
{
    class Program
    {
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
        
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int s1,s2,s3;
            s1 = s2 = s3 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            Shuffle(arr);
            Random rnd = new Random();
            int ind = rnd.Next(0, arr.Length);
            Array.Resize(ref arr,99);
            for (int i = 0; i < arr.Length; i++)
            {
                s2 += arr[i];
            }
            Array.Resize(ref arr,100);
            arr[99] = arr[ind];
            for (int i = 0; i < arr.Length; i++)
            {
                s3 += arr[i];
            }
            Console.WriteLine(arr[ind]);
            Console.WriteLine(s3-s2);
        }
    }
}
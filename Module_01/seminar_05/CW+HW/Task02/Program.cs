using System;
using System.Linq;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 11);
                Console.WriteLine(arr[i]);
                if (arr[i] % 2 == 0)
                    arr[i] = 0;
            }
            int num = 0;
            for (int i = arr.Length-2; i >= 0; i++)
            {
                if (arr[i] != 0)
                {
                    num = arr[i];
                    break;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    arr[i] = num;
                Console.Write(" " + arr[i]);
            }
        }
    }
}

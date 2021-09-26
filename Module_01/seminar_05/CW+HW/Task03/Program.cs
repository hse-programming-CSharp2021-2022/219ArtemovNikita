using System;
using System.Linq;
namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10,10);
                Console.Write(" " + arr[i]);
            }
            int endnum = arr[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0 && (arr[i] + arr[i+1]) != 0)
                {
                    arr[i] = arr[i] * arr[i + 1];
                    arr[i + 1] = endnum;
                    i += 1;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i; j < arr.Length-1; j++)
                {
                    if (arr[j] == endnum)
                    {
                        arr[j] = arr[j + 1];
                        arr[j + 1] = endnum;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Task02
{
    class Program
    {
        static void print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        static void print(List<int> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int sumofdigits(int num1, int num2)
        {
            var s1 = num1.ToString();
            var sum1 = 0;
            for (var i = 0; i < s1.Length; i++)
            {
                sum1 += int.Parse(s1[i].ToString());
            }
            
            var s2 = num2.ToString();
            var sum2 = 0;
            for (var i = 0; i < s2.Length; i++)
            {
                sum2 += int.Parse(s2[i].ToString());
            }

            if (sum1 > sum2)
                return -1;
            else if (sum2 > sum1)
                return 1;
            else
            {
                return 0;
            }

        }

        static bool E(int a)
        {
            var s = a.ToString();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }

            return true;
        }
        
        static void Main(string[] args)
        {
            var rnd = new Random();
            int n;
            int.TryParse(Console.ReadLine(), out n);

            //var arr = new int[n];
            int[] arr = {21, 36, 99, 1, 22, 353, 1441};
            int[] arr1 = arr.ToArray();
            
            print(arr);
            Console.WriteLine();
            Console.WriteLine();
                /*for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 10000);
            }*/

            Console.WriteLine("двузначные числа кратные 3: ");
            var ar3 = arr.Where(x => (x < 100) && (x > 9) && (x % 3 == 0)).ToArray();
            print(ar3);
            Console.WriteLine("\n");

            var arP = arr.Where(i => E(i)).OrderBy(i => i).ToArray();
            Array.Sort(arP);
            Console.WriteLine("Палиндромы: ");
            print(arP);
            Console.WriteLine("\n");

            Array.Sort(arr, sumofdigits);
            var arrsumdigits = arr.OrderBy(i => i).ToArray();
            Console.WriteLine("По сумме цифр: ");
            print(arrsumdigits);
            Console.WriteLine("\n");

            var sum = arr.Where(x => x.ToString().Length > 3).Sum();
            Console.WriteLine("Сумма чертыхзначных чисел: " + sum);

            var min = arr.Where(x => x.ToString().Length == 2).Min();
            Console.WriteLine("Min: " + min);

            var arrmax = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                string s = arr1[i].ToString();
                var digits = new int[s.Length];
                for (var j = 0; j < s.Length; j++)
                {
                    digits[j] = int.Parse(s[j].ToString());
                }
                arrmax[i] = digits.Max();
            }

            Console.WriteLine("Maxes: ");
            print(arrmax);
        }
    }
}
using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] mas = new char[k];
            Random r = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = (char)r.Next(65, 91);
                Console.Write(mas[i] + " ");
            }
            char[] copy = new char[k];
            Array.Copy(mas,copy, k);
            Console.WriteLine();
            Array.Sort(copy);
            
            Print(copy);
            Console.WriteLine();
            Array.Reverse(copy);
            Print(copy);
        }

        static void Print(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}
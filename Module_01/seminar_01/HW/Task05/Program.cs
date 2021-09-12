using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числовое значение катета A: ");
            int A;
            while (!int.TryParse(Console.ReadLine(), out A))
            {
                Console.Write("Введите корректное числовое значение катета A: ");
            }

            Console.Write("Введите числовое значение катета B: ");
            int B;
            while (!int.TryParse(Console.ReadLine(), out B))
            {
                Console.Write("Введите корректное числовое значение катета B: ");
            }

            double C =  Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            Console.WriteLine($"Числовое значение гипотенузы C равно - {C}; целая часть - {(int)C}");
        }
    }
}

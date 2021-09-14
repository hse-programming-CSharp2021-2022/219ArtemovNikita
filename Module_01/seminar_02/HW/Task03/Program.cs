using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double a = enter_length();
                double b = enter_length();
                double c = enter_length();
                double D = b * b - 4 * a * c;
                Console.WriteLine((D < 0) ? "вещественных корней не существует" : ((D == 0) ? ($"x1 = x2 = {(-b) / (2 * a)}") : ($"x1 = {(-b + Math.Sqrt(D)) / (2 * a)}, x2 = {(-b - Math.Sqrt(D)) / (2 * a)}")));

                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static double enter_length()
        {
            double A;
            Console.Write("Введите коэффициент: ");
            while (!double.TryParse(Console.ReadLine(), out A))
            {
                Console.Write("Введите корректное число: ");
            }
            return A;
        }
    }
}

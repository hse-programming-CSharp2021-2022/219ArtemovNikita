using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double x = enter_X();
                double Fx = x * (x * (x * (x + x + x + x + x + x + x + x + x + x + x + x + 9) - 3) + 2) - 4; // 3 умножения - оптимизировано
                Console.WriteLine("Значение полинома равно " + Fx);
                // сейчас я напишу второй алгоритм, очень медленный и неоптимизированный но без умножения :)
                double x2 = multiply(x, x);
                double x3 = multiply(x2, x);
                double x4 = multiply(x3, x);
                Fx = multiply(x4, 12) + multiply(x3, 9) - multiply(x2, 3) + multiply(x, 2) - 4;
                Console.WriteLine("Значение полинома равно " + Fx);
                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static double enter_X()
        {
            double x;
            Console.Write("Введите x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Введите корректный x: ");
            }
            return x;
        }

        public static double multiply(double a, double b)
        {
            if ((a < 0) && (b < 0))
            {
                a = -a;
                b = -b;
                return algorithm(a, b);
            }
            else if ((a > 0) && (b > 0))
            {
                return algorithm(a, b);
            }
            else if ((a == 0) | (b == 0)) return 0;
            else
            {
                if (a < 0) a = -a;
                else if (b < 0) b = -b;
                return -algorithm(a, b);
            }
        }

        public static double algorithm(double a, double b)
        {
            double res = 0;
            for (int i = 0; i < b; i++)
            {
                res += a;
            }
            return res;
        }
    }
}
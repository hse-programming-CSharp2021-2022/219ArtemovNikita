using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num;
                do
                {
                    Console.Write("Введите число: ");
                }
                while (!double.TryParse(Console.ReadLine(), out num));
                first_method(num);
                second_method(num);

                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void first_method(double num)
        {
            if ((int)num == 0) Console.WriteLine("Целая часть числа равно нулю");
            else Console.WriteLine("Целая часть числа равна " + (int)num);
            if (num == (int)num) Console.WriteLine("Дробную часть чилса выделить нельзя, число целое");
            else Console.WriteLine("Дробная часть числа равна " + (num - (int)num));
        }

        public static void second_method(double num)
        {
            Console.WriteLine("Квадрат числа равен " + (num * num));
            if (num < 0) Console.WriteLine("Число меньше нуля, выделить квадратный корень нельзя");
            else Console.WriteLine("квадратный корень числа равен " + Math.Sqrt(num));
        }
    }
}

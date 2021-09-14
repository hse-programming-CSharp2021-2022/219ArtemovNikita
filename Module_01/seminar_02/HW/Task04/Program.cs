using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num = 0;
                while ((num < 1000) || (num > 9999))
                {
                    Console.Write("Введите четырехзначное натуральное число: ");
                    num = enter_num(); // метод для ввода числа в консоли
                }
                int d1, d2, d3, d4;
                d1 = d2 = d3 = d4 = 0;
                digits(num, ref d1, ref d2, ref d3, ref d4);
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
                Console.WriteLine(d4);

                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static void digits(int num, ref int d1, ref int d2, ref int d3, ref int d4)
        {
            d1 = num % 10;
            num = (int)(num / 10);
            d2 = num % 10;
            num = (int)(num / 10);
            d3 = num % 10;
            num = (int)(num / 10);
            d4 = num % 10;
        }

        public static int enter_num()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Введите четырехзначное натуральное число: ");
            }
            return num;
        }
    }
}

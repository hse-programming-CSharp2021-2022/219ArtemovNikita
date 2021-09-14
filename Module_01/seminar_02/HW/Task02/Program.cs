using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int num = 0;
                while ((num < 100) || (num > 999))
                {
                    Console.Write("Введите натуральное трехзначное число: ");
                    num = enter_num(); // метод для ввода числа в консоли
                }

                int s1, s2, s3;
                s1 = s2 = s3 = 0;
                digitsofnum(num, ref s1, ref s2, ref s3);

                int maxnum = Math.Max(s1, Math.Max(s2, s3));
                int minnum = Math.Min(s1, Math.Min(s2, s3));
                int midnum;
                if (((s1 == maxnum) && (s2 == minnum)) | ((s2 == maxnum) && (s1 == minnum))) midnum = s3;
                else if (((s1 == maxnum) && (s3 == minnum)) | ((s3 == maxnum) && (s1 == minnum))) midnum = s2;
                else midnum = s1;
                Console.WriteLine(maxnum * 100 + midnum * 10 + minnum);

                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static int enter_num()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Введите натуральное трехзначное число: ");
            }
            return num;
        }

        public static void digitsofnum(int num, ref int s1, ref int s2, ref int s3)
        {
            s1 = num % 10;
            num = (int)(num / 10);
            s2 = num % 10;
            num = (int)(num / 10);
            s3 = num % 10;
        }
    }
}

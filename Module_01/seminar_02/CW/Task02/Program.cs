using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = enternum();
            printdigits(number);
        }

        public static void printdigits(int num)
        {
            int l = (int)Math.Log10(num) + 1;
            for (int i = l; i > 0; i--)
            {
                if (i == 0) Console.WriteLine(num%10);
                else Console.WriteLine((int)(num/(Math.Pow(10,i-1)))%10);
            }
        }

        public static int enternum()
        {
            int number;
            Console.Write("enter num: ");
            while (!int.TryParse(Console.ReadLine(), out number)) Console.Write("enter num: ");
            return number;
        }

    }
}

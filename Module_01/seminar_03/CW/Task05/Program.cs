using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Введите число: ");
            } while (!int.TryParse(Console.ReadLine(), out num));
            func(num);

        }
        public static void func(int num)
        {
            string s = num.ToString();
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            s = new String(a);
            num = int.Parse(s);
            Console.WriteLine(num);
        }
    }
}

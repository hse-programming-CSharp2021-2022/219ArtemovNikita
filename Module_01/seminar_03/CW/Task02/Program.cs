using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bl;
            bool p, q;
            do
            {
                Console.Write("Введите логическое p: ");
            } while (!bool.TryParse(Console.ReadLine(), out p));
            do
            {
                Console.Write("Введите логическое q: ");
            } while (!bool.TryParse(Console.ReadLine(), out q));
            f(p, q, out bl);
            Console.WriteLine(bl);
            bl = f(p, q);
            Console.WriteLine(bl);
        }

        public static void f(bool p, bool q, out bool bl)
        {
            bl = !(p & q) & !(p | !q);
        }
        public static bool f(bool p, bool q)
        {
            bool bl = !(p & q) & !(p | !q);
            return bl;
        }
    }
}

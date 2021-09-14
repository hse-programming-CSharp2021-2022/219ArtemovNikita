using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            forfunc();
            Console.WriteLine();
            whilefunc();
            Console.WriteLine();
            dowhilefunc();
        }

        public static void forfunc()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i*i + " ");
            }
        }
        public static void whilefunc()
        {
            int i = 1;
            while (i < 21)
            {
                Console.Write(i*i + " ");
                i++;
            }
        }
        public static void dowhilefunc()
        {
            int i = 1;
            do
            {
                Console.Write(i * i + " ");
                i++;
            } while (i < 21);
        }
    }
}

using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] classes = { Rnum(), Rnum(), Rnum() };
            int[] numofclasses = { classes[0] % 100, classes[1] % 100, classes[2] % 100 };
            Console.WriteLine(Math.Min(numofclasses[0],(Math.Min(numofclasses[1], numofclasses[2]))));
        }

        public static int Rnum()
        {
            Random rnd = new Random();
            int value = rnd.Next(100, 1000);
            return value;
        }
    }
}

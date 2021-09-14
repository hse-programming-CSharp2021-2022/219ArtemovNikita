using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double n1 = enter_num();
                double n2 = enter_num();
                double n3 = enter_num();
                Console.WriteLine((((n1 + n2) > n3) && ((n2 + n3) > n1) && ((n1 + n3) > n2)) ? ("Неравенство соблюдается, это стороны треугольника") : ("Неавенство не соблюдается, это не стороны треугольника"));


                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static public double enter_num()
        {
            double num;
            do
            {
                Console.Write("Введите cторону треугольника: ");
            } while (!double.TryParse(Console.ReadLine(), out num) || (num < 0));
            return num;
        }
    }
}

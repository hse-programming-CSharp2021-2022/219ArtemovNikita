using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double X = input("X");
                double Y = input("Y");
                bool f = meth(X, Y);
                if (f)
                    Console.WriteLine($"Точка с координатами ({X};{Y}) находится в данном круговом секторе.");
                else
                    Console.WriteLine($"Точка с координатами ({X};{Y}) не находится в данном круговом секторе.");

                Console.WriteLine("Чтобы продолжить работу программы нажмите Enter. Чтобы завершить работу программы нажмите Escape.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static bool meth(double x, double y)
        {
            if ((x == 0) && (y >= -2) && (y <= 0))
                return true;
            else if ((y == 0) && (x > 0) && (x <= 2))
                return true;
            else if ((x > 0) && (y < 0) && ((x * x + y * y) <= 4))
                return true;
            else if ((x > 0) && (y > 0) && ((x * x + y * y) <= 4) && ((y / x) <= 1) && ((y / x) >= 0))
                return true;
            else
                return false;
        }

        public static double input(string point)
        {
            double num;
            do
            {
                Console.Write($"Введите координату точки {point}: ");
            } while (!double.TryParse(Console.ReadLine(), out num));
            return num;
        }
    }
}

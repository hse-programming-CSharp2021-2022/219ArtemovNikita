using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение напряжения U: ");
            int U;
            while (!int.TryParse(Console.ReadLine(), out U))
            {
                Console.Write("Введите корректное значение напряжения U: ");
            }

            Console.Write("Введите значение сопротивления R: ");
            int R;
            while (!int.TryParse(Console.ReadLine(), out R))
            {
                Console.Write("Введите корректное значение сопротивления R: ");
            }

            double I = U / R;
            double P = Math.Pow(U, 2) / R;

            Console.WriteLine($"Сила тока равна - {I}; целая часть - {(int)I}");
            Console.WriteLine($"Потребляемая мощность равна - {P}; целая часть - {(int)P}");

        }
    }
}

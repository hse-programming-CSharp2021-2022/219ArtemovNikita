using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                decimal budget = enter_budget();
                int percent = enter_percent();
                decimal budget_for_games = budget * percent / 100;
                Console.WriteLine(budget_for_games.ToString("C"));

                Console.WriteLine("Чтобы закончить работу, нажмите escape, чтобы продолжить работу нажмите enter");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static public int enter_percent()
        {
            int num;
            do
            {
                Console.Write("Введите процент бюджета выделенный на игры: ");
            } while (!int.TryParse(Console.ReadLine(), out num) || ((num < 0) || (num > 100)));
            return num;
        }
        static public decimal enter_budget()
        {
            decimal num;
            do
            {
                Console.Write("Введите бюджет пользователя: ");
            } while (!decimal.TryParse(Console.ReadLine(), out num) || (num < 0));
            return num;
        }
    }
}

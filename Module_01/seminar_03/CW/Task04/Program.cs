using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Введите оценку от 1 до 10: ");
            } while (!int.TryParse(Console.ReadLine(), out num) && ((num>10) || (num<0)));
            switchfunc(num);
        }

        public static void switchfunc(int num)
        {
            switch (num) 
            {
                case < 4:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case < 6:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case < 8:
                    Console.WriteLine("Хорошо");
                    break;
                case < 11:
                    Console.WriteLine("Отлично");
                    break;
            }
        }
    }
}

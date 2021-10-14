using System;
namespace Task1
{
    class Program
    {
        static void Sum(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0; sumOdd = 0;
            while (number > 0)
            {
                sumEven = sumEven + number % 10;
                    sumOdd = sumOdd + (number / 10) % 10;
                number = number / 100;
            }
        }
        static void Main(string[] args)
        {
            uint number;
            bool num;
            do           
            {
                num = uint.TryParse(Console.ReadLine(), out number);
            } while (!num);
            Sum(number, out uint SumEven, out uint SumOdd);
            Console.WriteLine(SumEven + " " + SumOdd);
        }
    }
}
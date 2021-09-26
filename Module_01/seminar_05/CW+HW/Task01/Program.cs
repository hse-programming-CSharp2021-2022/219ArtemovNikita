using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            ulong number = num;
            ulong sortedNumber = 0;
            for (int i = 9; i >= 0; i--)
            {
                ulong Number = number;
                while (Number > 0)
                {
                    ulong digit = Number % 10;
                    if (digit == (ulong)i)
                    {
                        sortedNumber *= 10;
                        sortedNumber += digit;
                    }
                    Number /= 10;
                }
            }
            Console.WriteLine(sortedNumber);
        }
        
    }
}

using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            uint NOD, NOK;
            uint a = uint.Parse(Console.ReadLine());
            uint b = uint.Parse(Console.ReadLine());
            f(a,b,out NOD, out NOK);
            Console.WriteLine(NOD);
            Console.WriteLine(NOK);
        }

        static void f(uint a, uint b, out uint NOD, out uint NOK)
        {
            uint x = a, y = b;
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            NOD = x;
            NOK = 1;
            for (uint i = 1; i < (a * b+1);i++ )
            {
                if (i % a == 0 && i % b == 0)
                { 
                    NOK=i;
                    break;
                }
            }
        }
    }
}
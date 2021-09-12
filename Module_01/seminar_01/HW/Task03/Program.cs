using System;
using System.Security.Claims;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число Code от 32 до 127: ");
            int Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Изображение символа, представленное в таблице ASCII кодом Code: " + (char)Code);
            Console.ReadLine();
        }
    }
}

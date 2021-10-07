using System;
using System.Reflection;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin("5A1"));
            Console.WriteLine(ConvertHex2Bin("AA"));
            Console.WriteLine(ConvertHex2Bin("99"));
        }
        
        private static string ConvertHex2Bin(string hexString)
        {
            int value = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            string BinaryCode = Convert.ToString(value, 2);
            return BinaryCode;
        }
    }
}
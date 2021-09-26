using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch =  'a';
            if (Shift(ref ch))
                Console.WriteLine(ch);
        }
          

        static bool Shift(ref char ch)
        {
            if (!char.TryParse(Console.ReadLine(), out ch) || (int)ch < 97 || (int)ch > 122)
            {
                return false; 
            }
            int c = (int) ch;
            if (c > 118)
            {
                c = c - 22;
            }
            else
            {
                c += 4;
            }
            ch = (char) c;
            return true;
        }
    }
}

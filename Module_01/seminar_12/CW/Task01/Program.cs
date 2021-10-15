using System;
using System.Text.RegularExpressions;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "бык тупогуб, тупогубенький бычок, у быка губа бела была тупа.";
            var regex = new Regex(@"туп(\w*)");
            var matches = regex.Matches(s);

            foreach (var m in matches)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine();
            s = regex.Replace(s, "111");
            Console.WriteLine(s);

            Console.WriteLine();
            var s2 = "111-111-1111";
            var regex2 = new Regex(@"\d{3}-\d{3}-\d{4}");
            Console.WriteLine(regex2.IsMatch(s2));
        }
    }
}
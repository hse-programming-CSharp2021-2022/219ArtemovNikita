using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task 1: ");
            Task1();
            Console.WriteLine("\n");
            
            Console.WriteLine("task 2: ");
            Task2();
            Console.WriteLine("\n");
            
            Console.WriteLine("task 3: ");
            Task3();
            Console.WriteLine("\n");
        }


        static void Task1()
        {
            var s = Console.ReadLine();
            var regex = new Regex(@"\b\[a-zA-Z]{4}\b");
            var matches = regex.Matches(s);
            foreach (var el in matches)
            {
                Console.Write(el + " ");
            }
        }

        static void Task2()
        {
            var s = Console.ReadLine();
            var regex = new Regex(@"\b[a-zA-Z]*a\b");
            var matches = regex.Matches(s);
            foreach (var el in matches)
            {
                Console.Write(el + " ");
            }
        }

        static void Task3()
        {
            var s = Console.ReadLine();
            var regex = new Regex(@"[0-9]+");
            var matches = regex.Matches(s);
            var matcharray = new string[matches.Count];
            var maxlen = 0;
            for (int i = 0; i < matches.Count; i++)
            {
                matcharray[i] = matches[i].ToString();
                maxlen = Math.Max(maxlen, matcharray[i].Length);
            }

            var maxmatches = matcharray.Where(x => x.Length == maxlen).ToArray();
            foreach (var el in maxmatches)
            {
                Console.Write(el + " ");
            }


        }
    }
}
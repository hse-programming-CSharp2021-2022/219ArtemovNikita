using System;
using System.IO;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string path = @"data.txt";
            Console.WriteLine("enter n: ");
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            var rnd = new Random();
            for (var i = 0; i < n; i++)
                array[i] = rnd.Next(10, 101);
            var s = n % 5 == 0 ? new string[n / 5] : new string[n / 5 + 1];
            var k = 0;
            bool flag = array.Length % 5 == 0;
            for (var i = 0; i < s.Length; i++)
            {
                var sb = new StringBuilder();
                if (!flag && i == s.Length - 1)
                {
                    for (var j = 0; j < array.Length % 5; j++)
                    {
                        sb.Append(array[k] + " ");
                        k++;
                    }
                }
                else
                {
                    for (var j = 0; j < 5; j++)
                    {
                        sb.Append(array[k] + " ");
                        k++;
                    }
                }
                s[i] = sb.ToString();
            }
            File.WriteAllLines(path, s);
            //2
            var lines = File.ReadAllLines(path);
            var intarray = new int[array.Length];
            k = 0;
            for (var i = 0; i < lines.Length; i++)
            {
                var c = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < c.Length; j++)
                {
                    intarray[k] = int.Parse(c[j]);
                    k++;
                }
            }
            //3
            var cE = 0;
            var cO = 0;
            for (var i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] % 2 == 0)
                    cE++;
                else
                {
                    cO++;
                }
            }

            var indE = new int[cE];
            var indO = new int[cO];

            var kE = 0;
            var kO = 0;

            for (var i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] % 2 == 0)
                {
                    indE[kE] = i;
                    kE++;
                }
                else
                {
                    indO[kO] = i;
                    kO++;
                }
            }
            //4
            for (var i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] % 2 == 1)
                    intarray[i] = 0;
                Console.Write(intarray[i] + " ");
            }
            
        }
    }
}
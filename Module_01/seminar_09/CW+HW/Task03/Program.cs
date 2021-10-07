using System;
using System.Text;
using System.Linq;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                t01();
                Console.WriteLine();
                t02();
                Console.WriteLine();
                t03();
            }
            catch
            {
                Console.WriteLine("Может все-таки вводить данные, которые нужно?)");
                Console.WriteLine("ОЙ, я тут цитатник вшэ открыл" +
                                  "и такую фразу нашел...." +
                                  "\n\"Куда студента не целую, все равно получится в попу\"");
            }
        }

        static void t01()
        {
            string s = Console.ReadLine();
            var sArr = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            for (var i = 0; i < sArr.Length; i++)
            {
                sb.Append(sArr[i]+" ");
                
            }
            Console.WriteLine(sb);
        }
        
        static void t02()
        {
            string s = Console.ReadLine();
            var sArr = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var count = 0;
            for (var i = 0; i < sArr.Length; i++)
            {
                if (sArr[i].Length > 4)
                    count += 1;
            }
            Console.WriteLine("Количество слов,в которых больше 4 смиволов: " + count);
        }

        static void t03()
        {
            char[] vowels = {'а', 'А', 'У', 'у', 'е', 'Е', 'ы', 'Ы', 'о', 'О', 'э', 'Э', 'ё', 'Ё', 'я', 'Я', 'И', 'и', 'ю', 'Ю' };
            string s = Console.ReadLine();
            var sArr = s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var count = 0;
            for (var i = 0; i < sArr.Length; i++)
            {
                if (vowels.Contains(sArr[i][0]))
                    count += 1;
            }
            Console.WriteLine("Количество слов, которые начинаются с гласной: " + count);
        }
    }
}
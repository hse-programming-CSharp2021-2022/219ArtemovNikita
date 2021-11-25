using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            var x = 10;
            Console.WriteLine(x / 0);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("путь тебе в пределы, самурай, деление на ноль не сюда");
        }

        try
        {
            var arr = new int[] {1, 2, 3};
            Console.WriteLine(arr[4]);
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("не туда понесло, вернись в границы индекса");
        }

        try
        {
            bool x = true;
            var ch = Convert.ToChar(x);
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("ну нельзя из була в чар, что сказать");
        }

        try
        {
            string sr = null;
            sr.Split();
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("нуллы ловишь)");
        }
        
        try
        {
            int.Parse("daf");
        }
        catch (FormatException)
        {
            Console.WriteLine("парсим символы в инт?");
        }

        try
        {
            var d = new Dictionary<int, int>();
            d.Add(1,1);
            d.Add(1,1);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("два одинаковых ключика в один словарь низя");
        }

        checked
        {
            try
            {
                byte v = 213;
                sbyte t = (sbyte) v;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнился чутка(преисполнился на самом деле)");
            }
        }

        try
        {
            var d = new DriveInfo("gg");
        }
        catch
        {
            Console.WriteLine("диск gg? реально? drivenotfound лови");
        }
        
        try
        {
            string smth = null;
            Console.WriteLine("в".IndexOf(smth));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Аргумент не должен быть Null!!!!");
        }
        
        try
        {
            Directory.SetCurrentDirectory("чето там");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("директория не нашлась, нет ее вот и все");
        }
    }
}
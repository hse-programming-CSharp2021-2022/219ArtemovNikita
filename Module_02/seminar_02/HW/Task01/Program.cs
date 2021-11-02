using System;

namespace Task01
{
    class Program
    {
        static void Main( )
        {
            var sym1 = new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red);
            var sym2 = new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta);
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 35);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            Console.ForegroundColor = sym1.PlateColor;
                            Console.BackgroundColor = sym1.BackColor;
                            Console.Write(sym1.PlateChar);
                        }
                        else
                        {
                            Console.ForegroundColor = sym2.PlateColor;
                            Console.BackgroundColor = sym2.BackColor;
                            Console.Write(sym2.PlateChar);
                        }
                    }
                    else
                    {
                        if (j % 2 != 0)
                        {
                            Console.ForegroundColor = sym1.PlateColor;
                            Console.BackgroundColor = sym1.BackColor;
                            Console.Write(sym1.PlateChar);
                        }
                        else
                        {
                            Console.ForegroundColor = sym2.PlateColor;
                            Console.BackgroundColor = sym2.BackColor;
                            Console.Write(sym2.PlateChar);
                        }
                    }
                }

                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }

    
    public class ConsolePlate
    {
        char _plateChar; 
        ConsoleColor _plateColor = ConsoleColor.White;
        private ConsoleColor _backColor = ConsoleColor.Black;
        

        public ConsolePlate()  
        {
            _plateChar = 'A';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor backColor)
        {
            if (plateColor == backColor)
            {
                Console.WriteLine("Ошибка! Цвета заднего и переднего плана не должны совпадать!");
                return;
            }
            PlateChar = plateChar;
            PlateColor = plateColor;
            BackColor = backColor;
        }
        public char PlateChar
        {
            set
            {
                if (value >= 65 || value <= 90) 
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get { return _plateChar; }
        }
        public ConsoleColor PlateColor
        {
            set { _plateColor = value; }
            get { return _plateColor; }
        }

        public ConsoleColor BackColor
        {
            get { return _backColor; }
            set { _backColor = value; }
        }

    }

}
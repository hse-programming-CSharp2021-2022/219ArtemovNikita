using System;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main()
        {
            do
            {
                var rnd = new Random();
                var video = new VideoFile(RandomName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                Console.WriteLine("Информация об отдельном видеофайле:");
                video.GetInfo();
                int n = rnd.Next(5, 16);
                var videos = new VideoFile[n];
                Console.WriteLine("\nИнформация о видеофайлах из массива чей размер больше чем размер отдельного видеофайла:");
                for (var i = 0; i < n; i++)
                {
                    rnd = new Random();
                    videos[i] = new VideoFile(RandomName(), rnd.Next(60, 361), rnd.Next(100, 1001));
                    if (videos[i].Size > video.Size)
                    {
                        videos[i].GetInfo();
                    }
                }

                Console.WriteLine("\nДля завершения программы нажмите escape, для продолжения нажмите любую другую клавишу.");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static string RandomName()
        {
            var rnd = new Random();
            var n = rnd.Next(2, 10);
            var sb = new StringBuilder("");
            for (var i = 0; i < n; i++)
            {
                sb.Append((char)rnd.Next(65, 91));
            }

            return sb.ToString();
        }
    }

    class VideoFile
    {
        private readonly string _name;
        private readonly int _duration;
        private readonly int _quality;
        public int Size => _duration * _quality;
        public VideoFile(string name, int duration, int quality)
        {
            _name = name;
            _duration = duration;
            _quality = quality;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {_name}. Качество: {_quality}. Длительность: {_duration}. Размер: {Size}.");
        }
    }
}











using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m, n];
            int s = 1;
            for (int y = 0; y < n; y++) {
                array[0, y] = s;
                s++;
            }
            
            for (int x = 1; x < m; x++) {
                array[x, n - 1] = s;
                s++;
            }
            
            for (int y = n - 2; y >= 0; y--) {
                array[m - 1, y] = s;
                s++;
            }
            
            for (int x = m - 2; x > 0; x--) {
                array[x, 0] = s;
                s++;
            }
            
            // заполнили внешнее кольцо
            int i = 1, j = 1;
            while (s < m * n) 
            {
                while (array[i, j + 1] == 0) {
                    array[i, j] = s;
                    s++;
                    j++;
                }
                
                while (array[i + 1, j] == 0) {
                    array[i, j] = s;
                    s++;
                    i++;
                }
                
                while (array[i, j -1] == 0) {
                    array[i, j] = s;
                    s++;
                    j--;
                }
                
                while (array[i - 1, j] == 0) {
                    array[i, j] = s;
                    s++;
                    i--;
                }
            }

            for (int x = 0; x < m; x++) {
                for (int y = 0; y < n; y++)
                {
                    if (array[x, y] == 0)
                        array[x, y] = s;
                    Console.Write(array[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
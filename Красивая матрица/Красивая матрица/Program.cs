using System;

namespace Красивая_матрица
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] s = new string[5][];
            for (int i = 0; i < 5; i++)
                s[i] = Console.ReadLine().Split(' ');
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (s[i][j] == "1")
                        Console.WriteLine(Math.Abs(3 - (i + 1)) + Math.Abs(3 - (j + 1)));
                }
            }
        }
    }
}

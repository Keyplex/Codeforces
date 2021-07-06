using System;

namespace Слишком_длинные_слова
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();

                if (word.Length > 10)
                    word = $"{word[0]}{word.Length - 2}{word[word.Length - 1]}";

                Console.WriteLine(word);
            }
        }
    }
}

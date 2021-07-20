using System;

namespace Капитализация_слова
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            Console.WriteLine(char.ToUpper(a[0]) + a.Substring(1));
        }
    }
}

using System;

namespace Петя_и_строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine().ToLower();
            string b = Console.ReadLine().ToLower();
            Console.WriteLine(a.CompareTo(b));
        }
    }
}

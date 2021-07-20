using System;
using System.Linq;

namespace Перевод
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string(Console.ReadLine().Reverse().ToArray()) == Console.ReadLine() ? "YES" : "NO");
        }
    }
}

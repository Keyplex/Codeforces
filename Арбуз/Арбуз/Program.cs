using System;

namespace Арбуз
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = int.Parse(Console.ReadLine());

            var isGreat2AndDivideBy2 = w > 2 && w % 2 == 0;

            var an = isGreat2AndDivideBy2 ? "YES" : "NO";

            Console.WriteLine(an);
        }
    }
}

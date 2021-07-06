using System;
using System.Linq;

namespace Укладка_доминошками
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] serch = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(serch[0] * (serch[1] / 2) + (serch[1] % 2) * (serch[0] / 2));
            Console.ReadLine();
        }
    }
}

using System;
using System.Linq;

namespace Команда
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                result += Console.ReadLine().Split(" ").Where(x => x == "1").Count() > 1 ? 1 : 0;
            }

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Linq;

namespace Следующий_раунд
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = Convert.ToInt32(input[0]);
            int k = Convert.ToInt32(input[1]);

            string[] scores = Console.ReadLine().Split(" ");
            Console.WriteLine(scores.Where(x => Convert.ToInt32(x) >= Convert.ToInt32(scores[k - 1]) && Convert.ToInt32(x) > 0).Count());
        }
    }    
}

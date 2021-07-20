using System;
using System.Linq;

namespace Девушка_или_Юноша
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Console.ReadLine().Distinct().Count();
            if ((n&1)==1)
            {
                Console.WriteLine("IGNORE HIM!");
            }
            else
            {
                Console.WriteLine("CHAT WITH HER!");
            }               
        }
    }
}

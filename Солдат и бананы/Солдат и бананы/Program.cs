using System;

namespace Солдат_и_бананы
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int k = int.Parse(s[0]);
            int n = int.Parse(s[1]);
            int w = int.Parse(s[2]);
            int count = 0;
            for (int i = 1; i <= w; i++)
            {
                count += k * i;
            }
            int d = (count > n) ? (count - n) : 0;
            Console.WriteLine(d);
        }
    }
}

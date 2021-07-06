using System;

namespace Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int r = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s == "X++" || s == "++X")
                {
                    r++;
                }
                else
                {
                    r--;
                }
            }
            Console.WriteLine(r);
        }
    }
}

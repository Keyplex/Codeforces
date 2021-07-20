using System;

namespace Камни_на_столе
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (c[i-1]==c[i])                
                    count++;            
            }
            Console.WriteLine(count);
        }
    }
}

using System;
using System.Text;

namespace Очередь_в_школе
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Console.ReadLine().Split(' ');
            int n = int.Parse(id[0]);
            int x = int.Parse(id[1]);
            var str = new StringBuilder(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (str[i] == 'B' && str[i+1] == 'G')
                    {
                        str[i] = 'G';
                        str[i + 1] = 'B';
                        i++;
                    }
                }
            }
            Console.WriteLine(str);
        }
    }
}

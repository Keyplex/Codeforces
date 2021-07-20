using System;
using System.Linq;

namespace Математика_спешит_на_помощь
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var number = s.Split("+").OrderBy(x => Convert.ToInt32(x));
            var result = string.Empty;
            foreach (var item in number)
            {
                result += item + "+";
            }
            Console.WriteLine(result.Trim('+'));
        }
    }
}

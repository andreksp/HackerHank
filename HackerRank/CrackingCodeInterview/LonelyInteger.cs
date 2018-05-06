using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class LonelyInteger
    {
        static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var dic = a.GroupBy(p => p).ToDictionary(g => g.Key, g => g.Count());

            var res = dic.Where(p => p.Value == 1).First();

            Console.WriteLine(res.Key);
        }
    }
}

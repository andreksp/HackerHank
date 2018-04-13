using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class RecursiveStaircase
    {
        public static void Run()
        {
            int s = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < s; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CountStairCase(n));
            }
        }

        static Dictionary<int, int> cache = new Dictionary<int, int>();
        public static int CountStairCase(int n)
        {

            return CountStairCase(n - 1, 1) + CountStairCase(n - 2, 2) + CountStairCase(n - 3, 3);
        }

        public static int CountStairCase(int n, int step)
        {

            if (n == 0)
            {
                return 1;
            }
            else if (n < 0)
            {
                return 0;
            }
            else
            {
                if (!cache.ContainsKey(n))
                {
                    var res = CountStairCase(n - 1, 1) + CountStairCase(n - 2, 2) + CountStairCase(n - 3, 3);
                    cache.Add(n, res);
                    return res;
                }
                else
                {
                    return cache[n];
                }

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class DivisibleSumPairs
    {
        public static void ProcessMain()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = ProcessDivisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
        public static int ProcessDivisibleSumPairs(int n, int k, int[] ar)
        {
            int total = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if ((ar[i] + ar[j]) % k == 0)
                    {
                        total++;
                    }
                }
            }
            return total;
        }
    }
}

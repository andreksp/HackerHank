using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    /// <summary>
    /// Given a number of dollars, and a list of dollar values for  distinct coins
    /// find and print the number of different ways you can make change for  
    /// dollars if each coin is available in an infinite quantity.
    /// </summary>
    public class CoinChange
    {
        public static void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] coins_temp = Console.ReadLine().Split(' ');
            int[] coins = Array.ConvertAll(coins_temp, Int32.Parse);

            long ret = CountCoinChange(m, n, coins);

            Console.WriteLine(ret);

        }

        public static long CountCoinChange(int m, int n, int[] coins)
        {
            long[] vector = new long[n + 1];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = 0;
            }

            vector[0] = 1;

            for (int i = 0; i < m; i++)
            {
                for (int j = coins[i]; j <= n; j++)
                {
                    vector[j] += vector[j - coins[i]];
                }
            }

            return vector[n];
        }
    }
}

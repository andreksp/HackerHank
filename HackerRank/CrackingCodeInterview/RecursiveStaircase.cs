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
                Console.WriteLine("CountStairCase: " + CountStairCase(n));
                Console.WriteLine("StairMatrixExp: " + StairMatrixExp(n));
            }
        }

        static Dictionary<int, int> cache = new Dictionary<int, int>();

        /// <summary>
        /// Solution O(N) with DP
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int CountStairCase(int n)
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
                    var res = CountStairCase(n - 1) + CountStairCase(n - 2) + CountStairCase(n - 3);
                    cache.Add(n, res);
                    return res;
                }
                else
                {
                    return cache[n];
                }

            }
        }

        /// <summary>
        /// Solution O(Log n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long StairMatrixExp(int n)
        {
            long[][] m = new long[3][] { new long[] { 1, 1, 1 }, new long[] { 1, 0, 0 }, new long[] { 0, 1, 0 } };

            long[][] current = new long[3][] { new long[] { 1, 1, 1 }, new long[] { 1, 0, 0 }, new long[] { 0, 1, 0 } };

            var binary = Convert.ToString(n - 1, 2).ToCharArray();

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    current = Multiply(current, m);
                }

                if (i > 0)
                    m = Multiply(m, m);
            }

            return current[0][0];
        }

        public static long[][] Multiply(long[][] f, long[][] m)
        {
            long[][] newM = new long[3][] { new long[] { 0, 0, 0 }, new long[] { 0, 0, 0 }, new long[] { 0, 0, 0 } };

            for (int r = 0; r < f.Length; r++)
            {
                for (int c = 0; c < f.Length; c++)
                {
                    long x = 0;
                    for (int k = 0; k < f.Length; k++)
                    {
                        x += f[r][k] * m[k][c];
                    }

                    newM[r][c] = x;
                }
            }

            return newM;
        }
    }
}

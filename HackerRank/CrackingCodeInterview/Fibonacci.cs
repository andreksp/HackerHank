using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class FibonacciClass
    {


        public static void Run()
        {
            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("FibonacciRec: " + Fibonacci(n));
                Console.WriteLine("FibonacciIte: " + FibonacciIterative(n));
                Console.WriteLine("FibonacciMatrixExp: " + FibonacciMatrixExp(n));
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Complexity o(2^n)
        /// DP programming is o(N)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 2) + Fibonacci(n - 1);
        }

        /// <summary>
        /// Complexity O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int FibonacciIterative(int n)
        {
            /*
             * a  b  r
             * 0  1  1
             * 1  1  2
             * 1  2  3
             */

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                var r = a + b;
                a = b;
                b = r;
            }

            return a;

        }

        /// <summary>
        /// Matrix exponetial O(Log n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long FibonacciMatrixExp(int n)
        {
            long[][] m = new long[2][] { new long[] { 1, 1 }, new long[] { 1, 0 } };

            long[][] current = new long[2][] { new long[] { 1, 1 }, new long[] { 1, 0 } };

            var binary = Convert.ToString(n - 1, 2).ToCharArray();

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    current = Multiply(current, m);
                }

                if ( i > 0)
                    m = Multiply(m, m);
            }

            return current[0][1];

        }

        public static long[][] Multiply(long[][] f, long[][] m)
        {
            long[][] newM = new long[2][] { new long[] { 0, 0 }, new long[] { 0, 0 } };

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

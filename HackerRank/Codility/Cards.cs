using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Codility
{
    public class Cards
    {
        public static void Run()
        {
            Console.WriteLine(Solve(new int[] { 1, 2, 4, 3 }, new int[] { 1, 3, 2, 3 }));
            Console.WriteLine(Solve(new int[] { 3, 2, 1, 6, 5 }, new int[] { 4, 2, 1, 3, 3 }));
            Console.WriteLine(Solve(new int[] { 1, 2 }, new int[] { 1, 2 }));
        }
        public static int Solve(int[] f, int[] b)
        {
            int min = int.MaxValue;
            bool found = false;

            for (int i = 0; i < f.Length; i++)
            {
                if (f[i] < b[i])
                {
                    if (f[i] < min)
                    {
                        min = f[i];
                        found = true;
                    }
                }
            }

            if (!found)
            {
                return 3;
            }
            else
            {
                return min;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class DFSConnectedCellInAGrid
    {

        public static int[][] cache = null;

        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            cache = new int[n][];

            int[][] grid = new int[n][];
            for (int grid_i = 0; grid_i < n; grid_i++)
            {
                string[] grid_temp = Console.ReadLine().Split(' ');
                grid[grid_i] = Array.ConvertAll(grid_temp, Int32.Parse);

                cache[grid_i] = new int[m];
            }
            int max = CheckAll(grid, n, m);
            Console.WriteLine(max);
        }

        public static int CheckAll(int[][] grid, int n, int m)
        {
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var temp = CountMax(grid, i, j);

                    if (temp > max)
                        max = temp;
                }
            }

            return max;
        }


        public static int CountMax(int[][] grid, int l, int c)
        {

            if (l >= grid.Length || c >= grid[0].Length || l < 0 || c < 0)
                return 0;

            if (cache[l][c] > 0)
                return 0;

            var max = grid[l][c];

            cache[l][c] = 1;

            if (max > 0)
            {
                var maxa = CountMax(grid, l + 1, c);
                maxa += CountMax(grid, l, c + 1);
                maxa += CountMax(grid, l + 1, c + 1);

                maxa += CountMax(grid, l - 1, c);
                maxa += CountMax(grid, l - 1, c + 1);

                maxa += CountMax(grid, l, c - 1);
                maxa += CountMax(grid, l - 1, c - 1);
                maxa += CountMax(grid, l + 1, c - 1);
                max += maxa;
            }
            return max;
        }
    }
}

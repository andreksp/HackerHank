using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Data_Structures.Arrays
{
    public class _2DArrayDS
    {
        public static void ProcessMain()
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            Console.WriteLine(Process2DArrayDS(arr));
        }

        static int Process2DArrayDS(int[][] arr)
        {
            int maxHourGlass = int.MinValue;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    int hCSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 1][j + 1]
                                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    if ( hCSum > maxHourGlass)
                    {
                        maxHourGlass = hCSum;
                    }
                }
            }

            return maxHourGlass;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Data_Structures.Arrays
{
    public class ArraysDS
    {
        public static void ProcessMain()
        {
           
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Console.WriteLine(string.Join(" ", ProcessArraysDS(arr)));
        }

        static int[] ProcessArraysDS(int[] arr)
        {
            int[] newArray = new int[arr.Length];
            int count = 0;
            for (int i = arr.Length - 1; i >= 0; i--, count++)
            {
                newArray[count] = arr[i];
            }

            return newArray;
        }
    }
}

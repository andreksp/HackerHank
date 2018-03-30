using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class ArrayLeftRotation
    {
        static void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            List<int> temp = new List<int>();

            for (int i = 0; i < k; i++)
            {
                temp.Add(a[i]);
            }

            for (int i = 0; i < n - k; i++)
            {
                a[i] = a[i + k];
            }

            int count = 0;
            for (int i = n - k; i < n; i++)
            {
                a[i] = temp[count];
                count++;
            }

            Console.WriteLine(string.Join(" ", a));

        }
    }
}

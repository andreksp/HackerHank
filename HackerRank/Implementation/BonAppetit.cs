using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class BonAppetit
    {
        static int ProcessBonAppetit(int n, int k, int b, int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if (i != k)
                {
                    sum += ar[i];
                }
            }

            int bActual = sum / 2;

            int rest = b - bActual;

            return rest;
        }

        static void ProcessMain(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            int result = ProcessBonAppetit(n, k, b, ar);

            if (result != 0)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Bon Appetit");
            }
        }
    }
}

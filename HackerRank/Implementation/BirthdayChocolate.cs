using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    public class BirthdayChocolate
    {
        public static void ProcessMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = ProcessBirthdayChocolate(n, s, d, m);
            Console.WriteLine(result);
        }
        public static int ProcessBirthdayChocolate(int n, int[] s, int d, int m)
        {
            int sum = 0;
            int total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                sum = 0;
                for (int j = i; j < i + m && j < s.Length; j++)
                {
                    sum += s[j];
                    if (sum > d)
                        break;
                }

                if (sum == d)
                {
                    total += 1;
                }
            }

            return total;
        }
    }
}


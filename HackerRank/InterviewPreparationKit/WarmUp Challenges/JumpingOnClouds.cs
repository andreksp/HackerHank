using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPreparationKit.WarmUp_Challenges
{
    public class JumpingOnClouds
    {
        public static void ProcessMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var readLine = Console.ReadLine();
            Console.WriteLine(readLine);
            int[] ar = Array.ConvertAll(readLine.Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = ProcessJumpingOnClouds(ar);

            Console.WriteLine(result);
        }

        public static int ProcessJumpingOnClouds(int[] c)
        {
            int total = 0;
            for (int i = 0; i < c.Length - 1; i++)
            {
                if (c[i] == 1)
                    continue;

                if (i + 2 < c.Length && c[i] == c[i + 1] && c[i] == c[i + 2])
                {
                    i++;
                }

                total++;
            }
            return total;
        }
    }

}

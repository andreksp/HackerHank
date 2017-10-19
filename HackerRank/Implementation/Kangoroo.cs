using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    public class Kangoroo
    {
        public static void ProcessMain()
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            x1 = 1571;
            v1 = 4240;
            x2 = 9023;
            v2 = 4234;

            string result = Kangoroo.ProcessKangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }

        public static string ProcessKangaroo(int x1, int v1, int x2, int v2)
        {

            if (v1 < 0 || v2 < 0 || v1 > 10000 || v2 > 10000 || x1 < 0 || x1 > 10000 || x2 < 0 || x2 > 10000)
            {
                return "NO";
            }

            int lastDistance = Math.Abs(x1 - x2);

            while (x1 < int.MaxValue)
            {
                x1 = x1 + v1;
                x2 = x2 + v2;

                if (Math.Abs(x1 - x2) >= lastDistance)
                {
                    return "NO";
                }
                else
                {
                    lastDistance = Math.Abs(x1 - x2);
                }

                if (x1 == x2)
                    return "YES";
            }

            return "NO";
        }

    }
}

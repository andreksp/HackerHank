using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    public class BetweenSets
    {
        public static void ProcessMain()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
            int total = ProcessBetweenSets(a, b);
            Console.WriteLine(total);
        }

        static int ProcessBetweenSets(int[] a, int[] b)
        {

            int maximum = a.ToList().Concat(b.ToList()).Max();
            List<int> pn = new List<int>();

            for (int i = 1; i <= maximum; i++)
            {
                bool canStore = true;

                foreach (var itemA in a)
                {
                    if (i % itemA != 0)
                    {
                        canStore = false;
                        break;
                    }
                }

                if (canStore)
                {
                    foreach (var itemB in b)
                    {
                        if (itemB % i != 0)
                        {
                            canStore = false;
                            break;
                        }
                    }

                    if (canStore)
                    {
                        pn.Add(i);
                    }
                }
            }

            return pn.Count();
        }
    }
}

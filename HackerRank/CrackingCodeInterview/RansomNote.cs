using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class RansomNote
    {
        static void Run()
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            Dictionary<string, int> mag = new Dictionary<string, int>();

            foreach (var item in magazine)
            {
                if (!mag.ContainsKey(item))
                {
                    mag.Add(item, 1);
                }
                else
                {
                    mag[item] += 1;
                }
            }

            bool res = true;

            foreach (var r in ransom)
            {
                if (mag.ContainsKey(r))
                {
                    if (mag[r] > 0)
                    {
                        mag[r] -= 1;
                    }
                    else
                    {
                        res = false;
                        break;
                    }
                }
                else
                {
                    res = false;
                    break;
                }
            }

            Console.WriteLine(res ? "Yes" : "No");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    class BalancedBrakets
    {
        static void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<string> exps = new List<string>();
            for (int a0 = 0; a0 < t; a0++)
            {
                exps.Add(Console.ReadLine());
            }

            foreach (var exp in exps)
            {
                Console.WriteLine(CheckBalance(exp) ? "YES" : "NO");
            }
        }
        public static bool CheckBalance(string str)
        {
            var temp = str;

            var newStr = str.Replace("{}", "").Replace("[]", "").Replace("()", "");

            if (newStr == "")
                return true;

            if (temp != newStr)
            {
                return CheckBalance(newStr);
            }

            return false;
        }
    }
}

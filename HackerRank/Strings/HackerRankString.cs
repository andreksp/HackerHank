using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    public class HackerRankString
    {
        public static void ProcessMain()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = ProcessHackerRankString2(s);
                Console.WriteLine(result);
            }
        }

        public static string ProcessHackerRankString(string s)
        {
            string target = "hackerrank";

            int lastIndex = 0;
            int index = 0;

            for (int i = 0; i < target.Length; i++)
            {
                index = s.IndexOf(target[i], lastIndex);

                if (index == -1)
                {
                    return "NO";
                }

                lastIndex = index + 1;
            }

            return "YES";
        }

        //Second solution 
        public static string ProcessHackerRankString2(string s)
        {
            string target = "hackerrank";

            int lastIndex = 0;
            var chars = s.ToCharArray();
            int index = 0;
            bool found = false;

            for (int i = 0; i < target.Length; i++)
            {
                found = false;

                for (int j = lastIndex; j < chars.Length; j++)
                {
                    if (target[i] == chars[j])
                    {
                        index = j;
                        found = true;
                        break;                        
                    }
                }

                if (!found)
                    return "NO";

                lastIndex = index + 1;
            }

            return "YES";
        }
    }
}

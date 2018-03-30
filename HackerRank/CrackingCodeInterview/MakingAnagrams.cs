using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class MakingAnagrams
    {
        public static void Run()
        {
            string a = "cde";
            string b = "abc";

            int ret = 0;

            var groupedA = a.ToCharArray().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            var groupedB = b.ToCharArray().GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());


            foreach (var ga in groupedA)
            {
                if (groupedB.ContainsKey(ga.Key))
                {
                    ret += Math.Abs(ga.Value - groupedB[ga.Key]);
                }
                else
                { 
                    ret += ga.Value;
                }
            }

            foreach (var gb in groupedB)
            {
                if (!groupedA.ContainsKey(gb.Key))
                { 
                    ret += gb.Value;
                }
            }



            Console.WriteLine(ret);


        }
    }
}

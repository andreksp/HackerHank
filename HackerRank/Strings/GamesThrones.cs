using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    class GamesThrones
    {
        static string gameOfThrones(string s)
        {
            var charCount = s.GroupBy(c => c, (c, cn) => new
            {
                character = c,
                count = cn.Count()
            });

            var odds = charCount.Count(c => c.count % 2 == 1);


            return odds <= 1 ? "YES" : "NO";
        }
        

        public static void Run()
        {
            //string s = Console.ReadLine();
            string result = gameOfThrones("cdefghmnopqrstuvw");
            Console.WriteLine(result);
        }
    }
}

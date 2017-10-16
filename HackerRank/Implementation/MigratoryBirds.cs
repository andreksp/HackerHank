using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class MigratoryBirds
    {
        public static void ProcessMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);

            string txt = File.ReadAllText(@"F:\Projetos\Visual Studio 2017\HackerRank\HackerRank\Implementation\MigratoreText.txt");
            ar = Array.ConvertAll(txt.Split(' '), s => int.Parse(s));

            long result = ProcessMigratoryBirds(n, ar);
            Console.WriteLine(result);
        }

        static long ProcessMigratoryBirds(int n, int[] ar)
        {
            Dictionary<long, long> total = new Dictionary<long, long>();
            foreach (var item in ar)
            {
                if (!total.ContainsKey(item))
                    total.Add(item, 0);

                total[item] += 1;
            }

            var maxValue = total.OrderByDescending(x => x.Value).ThenBy(x => x.Key).First();

            return maxValue.Key;
        }
    }
}

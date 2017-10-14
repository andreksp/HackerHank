using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class BreakingBestRecords
    {
        public static void ProcessMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = BreakingBestRecords.ProcessBreakingBestRecords(s);
            Console.WriteLine(String.Join(" ", result));            
        }

        public static int[] ProcessBreakingBestRecords(int[] s)
        {
            int higherScore = 0;
            int lowerScore = 0;
            int lastHigherScore = s.ToList().First();
            int lastLoweScore = s.ToList().First();

            foreach (var item in s)
            {
                if (item > lastHigherScore)
                {
                    lastHigherScore = item;
                    higherScore++;
                }
                if (item < lastLoweScore)
                {
                    lastLoweScore = item;
                    lowerScore++;
                }
            }

            return new int[] { higherScore, lowerScore };
        }
    }
}

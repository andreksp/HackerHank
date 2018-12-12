using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPreparationKit.WarmUp_Challenges
{
    public class SockMerchant
    {
        public static void ProcessMain()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var readLine = Console.ReadLine();
            Console.WriteLine(readLine);
            int[] ar = Array.ConvertAll(readLine.Trim().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = processSockMerchant(n, ar);

            Console.WriteLine(result);
        }

        // Complete the sockMerchant function below.
        public static int processSockMerchant(int n, int[] ar)
        {
            var groupedValues = ar.ToList().GroupBy(p => p).ToDictionary(x => x.Key, x => x.Count());
            int totalPairs = 0;

            foreach (var grouped in groupedValues)
            {
                totalPairs += (int)(grouped.Value / 2);
            }

            return totalPairs;
        }
    }
}

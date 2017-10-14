using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    public class MiniMaxSum
    {
        public void ProcessMain()
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Console.WriteLine(ProcessMiniMaxSum(arr));
        }
        public string ProcessMiniMaxSum(int[] arr)
        {
            List<long> values = arr.ToList().ConvertAll(i => (long)i);

            return values.OrderBy(p => p).Take(4).Sum().ToString() + " " + values.OrderByDescending(p => p).Take(4).Sum().ToString();
        }

    }
}

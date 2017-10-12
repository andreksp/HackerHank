using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Implementation
{
    class MiniMaxSum
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            List<long> values = arr.ToList().ConvertAll(i => (long)i);

            Console.WriteLine(values.OrderBy(p => p).Take(4).Sum().ToString() + " " + values.OrderByDescending(p => p).Take(4).Sum().ToString());


        }
    }
}

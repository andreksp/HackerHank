using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    class CamelCase
    {
        public static void ProcessMain()
        {
            string s = Console.ReadLine();
            int result = ProcessCamelCase(s);
            Console.WriteLine(result);
        }

        static int ProcessCamelCase(string s)
        {
            var chars = s.ToCharArray();

            int total = 1;

            chars.ToList().ForEach(c => total += (c < 96) ? 1 : 0);

            return total;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPreparationKit.WarmUp_Challenges
{
    public class RepeatedString
    {
        public static void ProcessMain()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());
            long result = ProcessRepeatedString(s, n);

            Console.WriteLine(result);
        }

        static long ProcessRepeatedString(string s, long n)
        {
            int numberOfAs = s.ToCharArray().Where(p => p == 'a').Count();
            int totalChars = s.ToCharArray().Count();

            long totalNumberOfAs = ((long)(n / totalChars)) * numberOfAs;

            int missingChars = (int)(n % totalChars);

            if (missingChars > 0)
            {
                totalNumberOfAs += s.Substring(0, missingChars).ToCharArray().Where(p => p == 'a').Count();
            }
            return totalNumberOfAs;
        }
    }
}

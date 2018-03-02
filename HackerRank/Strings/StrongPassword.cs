using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Strings
{
    public class StrongPassword
    {
        public static void ProcessMain()
        {
            string s = Console.ReadLine();
            int result = ProcessStrongPassword(s);
            Console.WriteLine(result);
        }

        static int ProcessStrongPassword(string s)
        {
            var chars = s.ToCharArray();

            int total = 0;

            if (!chars.Any(c => char.IsDigit(c)))
            {
                total += 1;
            }

            if (!chars.Any(c => char.IsLower(c))) //lowercase
            {
                total += 1;
            }

            if (!chars.Any(c => char.IsUpper(c))) //upper
            {
                total += 1;
            }

            var special_characters = "!@#$%^&*()-+".ToCharArray();

            if (!chars.Any(c => special_characters.Contains(c)))
            {
                total += 1;
            }

            if (chars.Length + total < 6)
            {
                total += 6 - (chars.Length + total);
            }

            return total;
        }
    }
}
